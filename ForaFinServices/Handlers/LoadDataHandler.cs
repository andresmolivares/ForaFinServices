using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Handlers;

public class LoadDataHandler : BaseHandler
{
    private readonly IFundableAmountService _fundableAmountService;

    public LoadDataHandler(ILogger<LoadDataHandler> logger, IServiceProvider serviceProvider) : base(logger)
    {
        _fundableAmountService = serviceProvider.GetRequiredService<IFundableAmountService>();
    }

    public override IEnumerable<Type> GetSupportedMessageTypes() => [typeof(LoadDataCommand)];

    public override async Task HandleAsync(IMessage message)
    {
        switch(message)
        {
            case LoadDataCommand loadDataMessage:
                await HandleLoadData(loadDataMessage);
                break;
            default:
                await Task.CompletedTask;
                break;
        }
    }

    private async Task HandleLoadData(LoadDataCommand message)
    {
        await _fundableAmountService.PersistData();
    }
}
