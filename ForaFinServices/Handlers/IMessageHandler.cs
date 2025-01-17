using ForaFinServices.Handlers.Messages;

namespace ForaFinServices.Handlers;

public interface IMessageHandler
{
    Task HandleAsync(IMessage message);

    IEnumerable<Type> GetSupportedMessageTypes();
}
