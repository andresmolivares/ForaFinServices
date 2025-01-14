using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;

namespace ForaFinServices.Handlers;

public class CacheBatchDataHandler : BaseHandler

{
    private readonly BatchSettings _batchSettings;
    private readonly ParallelOptions _parallelOptions;
    private readonly ICompanyInfoCacheService _companyInfoCacheService;

    public CacheBatchDataHandler(ILogger<CacheBatchDataHandler> logger, BatchSettings batchSettings, ParallelSettings parallelSettings, ICompanyInfoCacheService companyInfoCacheService) : base(logger)
    {
        _batchSettings = batchSettings;
        _parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = parallelSettings.MaxDegreeOfParallelism };
        _companyInfoCacheService = companyInfoCacheService;
    }

    public override IEnumerable<Type> GetSupportedMessageTypes() => [typeof(CacheBatchDataMessage)];

    public override async Task HandleAsync(IMessage message)
    {
        switch(message)
        {
            case CacheBatchDataMessage cacheBatchDataMessage:
                await HandleCacheBatchData(cacheBatchDataMessage);
                break;
            default:
                await Task.CompletedTask;
                break;
        }

        await Task.CompletedTask;
    }

    private async Task HandleCacheBatchData(CacheBatchDataMessage message)
    {
        var batchSize = _batchSettings.Size;
        var batches = message.CikIds.Chunk(batchSize);

        foreach(var batch in batches)
        {
            await Parallel.ForEachAsync(batch, _parallelOptions, (id, cancellationToken) =>
            {
                try
                {
                    _ = _companyInfoCacheService.CacheData(id);
                }
                catch(Exception ex)
                {
                    _logger.LogError("HandleCacheBatchData Error for cik Id {0}: {1}", id, ex.Message);
                }

                return new ValueTask();
            });
        }
    }
}
