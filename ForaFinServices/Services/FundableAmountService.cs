﻿using ForaFinServices.DTO;
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

        public FundableAmountService(
            ILogger<FundableAmountService> logger, 
            ICompanyInfoCacheService companyInfoCacheService, 
            ICikDataService cikDataService,
            BatchSettings batchSettings,
            QueueService queueService,
            CikSettings cikSettings)
        {
            _companyInfoCacheService = companyInfoCacheService;
            _cikDataService = cikDataService;
            _logger = logger;
            _batchSettings = batchSettings;
            _queueService = queueService;
            _cikSettings = cikSettings;
        }

        public async Task PersistData()
        {
            try
            {
                var ids = await _cikDataService.GetCikIds(_cikSettings.FileName);
                _logger.LogDebug("Ids loaded.");

                await CacheCompanyInfoData(ids);

            }
            catch (Exception ex)
            {
                _logger.LogError("FundableAmountService PersistData Error: {0}", ex.Message);
            }
        }

        private async Task CacheCompanyInfoData(string[] ids)
        {
            var batchId = 1;
            var tasks = ids
                .Chunk(_batchSettings.Size)
                .Select(batch => 
                Task.Run(() => _queueService.PublishMessage(new CacheBatchDataCommand { BatchId = batchId++, CikIds = batch })));

            await Task.WhenAll(tasks);

            _queueService.PublishMessage(new BatchProcessingCompleteEvent());
        }

        public IEnumerable<FundableAmountDto> GetFundableAmount(string? letterFilter)
        {
            return _companyInfoCacheService.GetCompanyInfo(letterFilter)
                .Select(f => f.MapToFundableAmount());
        }

        public FundableAmountDto? GetSingleFundableAmount (string cikId)
        {
            var result = _companyInfoCacheService.GetCompanyInfoById(cikId);
            return result?.MapToFundableAmount();
        }
    }
}
