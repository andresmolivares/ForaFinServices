using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class WarmUpService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        public WarmUpService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var service = _serviceProvider.GetService<IFundableAmountService>();

                if (service != null)
                    await service.PersistData();
            }

            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
