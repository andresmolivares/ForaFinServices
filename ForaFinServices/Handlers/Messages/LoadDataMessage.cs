namespace ForaFinServices.Handlers.Messages; 

public record LoadDataMessage() : IMessage
{
    public string MessageType => nameof(LoadDataMessage);
}
