using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;
using ForaFinServices.Settings;
using System.Diagnostics;

namespace ForaFinServices.Handlers;

public class CacheBatchDataHandler : BaseHandler
{
    private readonly ParallelOptions _parallelOptions;
    private readonly ICompanyInfoCacheService _companyInfoCacheService;
    private readonly Stopwatch sw = new();

    public CacheBatchDataHandler(ILogger<CacheBatchDataHandler> logger, BatchSettings batchSettings, ParallelSettings parallelSettings, ICompanyInfoCacheService companyInfoCacheService) : base(logger)
    {
        _parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = parallelSettings.MaxDegreeOfParallelism };
        _companyInfoCacheService = companyInfoCacheService;
    }

    public override IEnumerable<Type> GetSupportedMessageTypes() => [
        typeof(CacheBatchDataCommand), 
        typeof(BatchProcessingCompleteEvent)
        ];

    public override async Task HandleAsync(IMessage message)
    {
        switch(message)
        {
            case CacheBatchDataCommand cacheBatchDataMessage:
                sw.Start();
                
                await HandleCacheBatchData(cacheBatchDataMessage);
                
                sw.Stop();
                _logger.LogCritical("Total HandleCacheBatchData time after batch {0}:  {1} seconds", cacheBatchDataMessage.BatchId, sw.Elapsed.TotalSeconds);
                break;
            case BatchProcessingCompleteEvent batchProcessingCompleteMessage:
                HandleResetBatchTimer(batchProcessingCompleteMessage);
                break;
            default:
                await Task.CompletedTask;
                break;
        }
    }

    private void HandleResetBatchTimer(BatchProcessingCompleteEvent resetBatchTimerMessage) => sw.Reset();

    private async Task HandleCacheBatchData(CacheBatchDataCommand message)
    {
        var tasks = new List<Task>();

        await Parallel.ForEachAsync(message.CikIds, _parallelOptions, (id, cancellationToken) =>
        {
            try
            {
                _logger.LogDebug("Message batchId: {0}", message.BatchId);
                tasks.Add(_companyInfoCacheService.CacheData(id));
            }
            catch(Exception ex)
            {
                _logger.LogError("HandleCacheBatchData Error for cik Id {0}: {1}", id, ex.Message);
            }
            return new ValueTask();
        });

        await Task.WhenAll(tasks);
    }
}
