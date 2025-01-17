namespace ForaFinServices.Handlers.Messages;

public record CacheBatchDataCommand() : IMessage
{
    public int BatchId { get; set; }
    public string MessageType => nameof(CacheBatchDataCommand);
    public string[] CikIds { get; set; } = Array.Empty<string>();
}
