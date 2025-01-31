using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Handlers;

public class PersistDataHandler : BaseHandler
{
    private readonly ICompanyInfoPersistService _companyInfoPersistService;

    public PersistDataHandler(
        ILogger<PersistDataHandler> logger,
        IServiceProvider serviceProvider) 
        : base(logger)
    {
        _companyInfoPersistService = serviceProvider.GetRequiredService<ICompanyInfoPersistService>();
    }

    public override IEnumerable<Type> GetSupportedMessageTypes() => [typeof(PersistDataCommand)];

    public override async Task HandleAsync(IMessage message)
    {
        switch(message)
        {
            case PersistDataCommand persistCompanyInfoMesssage:
                await HandlePersistData(persistCompanyInfoMesssage);
                break;
            default:
                await Task.CompletedTask;
                break;
        }
    }

    private async Task HandlePersistData(PersistDataCommand message)
    {
        await _companyInfoPersistService.PersistData(message);
    }
}
