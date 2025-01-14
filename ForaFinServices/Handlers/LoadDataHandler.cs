using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Handlers;

public class LoadDataHandler : BaseHandler
{
    private readonly IServiceProvider _serviceProvider;

    public LoadDataHandler(ILogger<LoadDataHandler> logger, IServiceProvider serviceProvider) : base(logger)
    {
        _serviceProvider = serviceProvider;
    }

    public override IEnumerable<Type> GetSupportedMessageTypes() => [typeof(LoadDataMessage)];

    public override async Task HandleAsync(IMessage message)
    {
        switch(message)
        {
            case LoadDataMessage loadDataMessage:
                await HandlePersistData(loadDataMessage);
                break;
            default:
                await Task.CompletedTask;
                break;
        }

        await Task.CompletedTask;
    }

    private async Task HandlePersistData(LoadDataMessage message)
    {
        var _fundableAmountService = _serviceProvider.GetRequiredService<IFundableAmountService>();
        await _fundableAmountService.PersistData();
    }
}
