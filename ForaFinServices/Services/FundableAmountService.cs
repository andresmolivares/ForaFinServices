using ForaFinServices.Extensions;
using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;

namespace ForaFinServices.Services
{
    public class FundableAmountService : IFundableAmountService
    {
        private readonly string Cik_FilePath = "CIKs.csv";
        private readonly ISecCompanyInfoService _secCompanyInfoService;
        private readonly ICikRepositoryService _cikRepositoryService;
        private readonly ILogger<FundableAmountService> _logger;
        private readonly ParallelOptions _parallelOptions;
        private readonly BatchSettings _batchSettings;

        public FundableAmountService(
            ILogger<FundableAmountService> logger, 
            ISecCompanyInfoService secCompanyInfoService, 
            ICikRepositoryService cikRepositoryService,
            ParallelSettings parallelSettings,
            BatchSettings batchSettings)
        {
            _secCompanyInfoService = secCompanyInfoService;
            _cikRepositoryService = cikRepositoryService;
            _logger = logger;
            _batchSettings = batchSettings;
            _parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = parallelSettings.MaxDegreeOfParallelism };
        }

        public async Task PersistData()
        {
            try
            {
                var ids = await _cikRepositoryService.GetCikIds(Cik_FilePath);
                _logger.LogInformation("Ids loaded.");
                await CacheCompanyInfoData(ids);
            }
            catch (Exception ex)
            {
                _logger.LogError("SEC Service Initialization Error: {0}", ex.Message);
            }
        }

        private async Task CacheCompanyInfoData(string[] ids)
        {
            var batches = ids.Chunk(_batchSettings.Size);

            foreach (var batch in batches)
            {
                await Parallel.ForEachAsync(batch, _parallelOptions, async (id, cancellationToken) =>
                {
                    try
                    {
                        await _secCompanyInfoService.CacheData(id);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("SEC Service Error for cik Id {0}: {1}", id, ex.Message);
                    }
                });
            }
        }

        public IEnumerable<FundableAmountResponse> GetFundableAmount(string letterFilter)
        {
            var companyInfos = _secCompanyInfoService.GetCompanyInfo(letterFilter);

            return companyInfos
                .Select(f => f.ToFundableAmountResponse())
                .OrderBy(f => f.Name);
        }
    }
}
