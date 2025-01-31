using ForaFinServices.DTO;
using ForaFinServices.Extensions;
using ForaFinServices.FundableRules;
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
        private readonly CikSettings _cikSettings;
        private readonly IEnumerable<ISpecialFundableRule> _specialFundableRules;
        private readonly IServiceProvider _serviceProvider;

        public FundableAmountService(
            ILogger<FundableAmountService> logger, 
            ICikDataService cikDataService,
            BatchSettings batchSettings,
            CikSettings cikSettings,
            ISpecialFundableRulesService specialFundableRulesService,
            IServiceProvider serviceProvider)
        {
            _companyInfoCacheService = serviceProvider.GetRequiredService<ICompanyInfoCacheService>(); ;
            _cikDataService = cikDataService;
            _logger = logger;
            _batchSettings = batchSettings;
            _serviceProvider = serviceProvider;
            _cikSettings = cikSettings;
            _specialFundableRules = specialFundableRulesService.GetSpecialFundableRules();
        }

        public async Task PersistData()
        {
            try
            {
                var ids = await _cikDataService.GetCikIds(_cikSettings.FileName);
                _logger.LogDebug("Ids loaded.");

                await CacheCompanyInfoData(ids);

                var _queueService = _serviceProvider.GetRequiredService<QueueService>();
                _queueService.PublishMessage(new BatchProcessingCompleteEvent());
            }
            catch (Exception ex)
            {
                _logger.LogError("FundableAmountService PersistData Error: {0}", ex.Message);
            }
        }

        private async Task CacheCompanyInfoData(string[] ids)
        {
            var batchId = 1;
            var _queueService = _serviceProvider.GetRequiredService<QueueService>();

            var tasks = ids
                .Chunk(_batchSettings.Size)
                .Select(batch => 
                Task.Run(() => _queueService.PublishMessage(new CacheBatchDataCommand { BatchId = batchId++, CikIds = batch })));

            await Task.WhenAll(tasks);
        }

        public IEnumerable<FundableAmountDto> GetFundableAmount(string? letterFilter)
        {
            return _companyInfoCacheService.GetCompanyInfo(letterFilter)
                .Select(f => f.MapToFundableAmount(_specialFundableRules));
        }

        public FundableAmountDto? GetSingleFundableAmount (string cikId)
        {
            var result = _companyInfoCacheService.GetCompanyInfoById(cikId);
            return result?.MapToFundableAmount(_specialFundableRules);
        }
    }
}
