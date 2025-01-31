namespace ForaFinServices.Handlers.Messages;

public class PersistDataCommand : IMessage
{
    public string MessageType => nameof(PersistDataCommand);
    public required string Data { get; set; }
    public required string Key { get; set; }
}
