namespace ForaFinServices.Handlers.Messages;

public record CacheBatchDataMessage() : IMessage
{
    public string MessageType => nameof(CacheBatchDataMessage);
    public string[] CikIds { get; set; } = Array.Empty<string>();
}
