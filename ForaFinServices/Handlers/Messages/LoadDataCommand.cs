namespace ForaFinServices.Handlers.Messages; 

public class LoadDataCommand : IMessage
{
    public string MessageType => nameof(LoadDataCommand);
}
