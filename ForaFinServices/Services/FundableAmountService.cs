using ForaFinServices.DTO;
using ForaFinServices.Extensions;
using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;

namespace ForaFinServices.Services
{
    public class FundableAmountService : IFundableAmountService
    {
        private readonly ICompanyInfoCacheService _companyInfoCacheService;
        private readonly ICikDataService _cikDataService;
        private readonly ILogger<FundableAmountService> _logger;
        private readonly BatchSettings _batchSettings;
        private readonly QueueService _queueService;
        private readonly CikSettings _cikSettings;
        private readonly ISpecialFundableRulesService _specialFundableRulesService;

        public FundableAmountService(
            ILogger<FundableAmountService> logger, 
            ICompanyInfoCacheService companyInfoCacheService, 
            ICikDataService cikDataService,
            BatchSettings batchSettings,
            QueueService queueService,
            CikSettings cikSettings,
            ISpecialFundableRulesService specialFundableRulesService)
        {
            _companyInfoCacheService = companyInfoCacheService;
            _cikDataService = cikDataService;
            _logger = logger;
            _batchSettings = batchSettings;
            _queueService = queueService;
            _cikSettings = cikSettings;
            _specialFundableRulesService = specialFundableRulesService;
        }

        public async Task PersistData()
        {
            try
            {
                var ids = await _cikDataService.GetCikIds(_cikSettings.FileName);
                _logger.LogDebug("Ids loaded.");

                CacheCompanyInfoData(ids);

            }
            catch (Exception ex)
            {
                _logger.LogError("FundableAmountService PersistData Error: {0}", ex.Message);
            }
        }

        private void CacheCompanyInfoData(string[] ids)
        {
            var batches = ids.Chunk(_batchSettings.Size);

            foreach (var batch in batches)
            {
                _queueService.PublishMessage(new CacheBatchDataMessage { CikIds = batch });
            }
        }

        public IEnumerable<FundableAmountDto> GetFundableAmount(string? letterFilter)
        {
            var specialFundableRules = _specialFundableRulesService.GetSpecialFundableRules();
            return _companyInfoCacheService.GetCompanyInfo(letterFilter)
                .Select(f => f.MapToFundableAmount(specialFundableRules));
        }

        public FundableAmountDto? GetSingleFundableAmount (string cikId)
        {
            var result = _companyInfoCacheService.GetCompanyInfoById(cikId);
            return result?.MapToFundableAmount(_specialFundableRulesService.GetSpecialFundableRules());
        }
    }
}
