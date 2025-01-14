using ForaFinServices.Services;

namespace ForaFinServices
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();
            // Manually running QueueService since it's registered for IoC access as singleton instead of hosted service.
            // This allows us to publish messages via the QueueService instance
            await scope.ServiceProvider.GetRequiredService<QueueService>()
                .StartAsync(CancellationToken.None);

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
