namespace ForaFinServices.Handlers.Messages;

public record BatchProcessingCompleteEvent() : IMessage
{
    public string MessageType => nameof(BatchProcessingCompleteEvent);
}
