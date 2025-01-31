namespace ForaFinServices.Handlers.Messages;

public class BatchProcessingCompleteEvent : IMessage
{
    public string MessageType => nameof(BatchProcessingCompleteEvent);
}
