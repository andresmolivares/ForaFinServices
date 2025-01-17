using ForaFinServices.Handlers.Messages;

namespace ForaFinServices.Handlers;

public abstract class BaseHandler : IMessageHandler
{
    protected readonly ILogger<BaseHandler> _logger;

    public BaseHandler(ILogger<BaseHandler> logger)
    {
        _logger = logger;
    }

    public abstract IEnumerable<Type> GetSupportedMessageTypes();
    public abstract Task HandleAsync(IMessage message);
}
