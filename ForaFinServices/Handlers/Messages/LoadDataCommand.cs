namespace ForaFinServices.Handlers.Messages; 

public record LoadDataCommand() : IMessage
{
    public string MessageType => nameof(LoadDataCommand);
}
