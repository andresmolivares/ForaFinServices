using ForaFinServices.DataModel;
using ForaFinServices.Handlers.Messages;
using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ForaFinServices.Services
{
    public class CompanyInfoPersistService : ICompanyInfoPersistService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly ILogger<CompanyInfoPersistService> _logger;

        public CompanyInfoPersistService(
            ILogger<CompanyInfoPersistService> logger,
            IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }


        public async Task PersistData(PersistDataCommand message)
        {
            using var scope = _serviceProvider.CreateScope();
            var _dbContext = scope.ServiceProvider.GetRequiredService<ForaFinDbContext>();
            _logger.LogInformation("Persisting item to database {0}", message.Key);

            var companyInfo = JsonSerializer.Deserialize<CompanyInfo>(message.Data, _serializerOptions)!;

            // Persist data database
            if(_dbContext.CikItems.Find(message.Key) == null)
            {
                var cikItem = new CikItem { Key = message.Key, Data = message.Data, Name = companyInfo.EntityName };
                _dbContext.CikItems.Add(cikItem);
                _dbContext.SaveChanges();
            }

            await Task.CompletedTask;
        }

        public IEnumerable<CompanyInfo> GetCompanyInfoList(string[] cikIds)
        {
            // Get persisted data
            using var scope = _serviceProvider.CreateScope();
            var _dbContext = scope.ServiceProvider.GetRequiredService<ForaFinDbContext>();
            _logger.LogInformation("Retrieving items from database {0}", cikIds);
            return _dbContext.CikItems
                .Where(item => cikIds.Contains(item.Key))
                .Select(item => JsonSerializer.Deserialize<CompanyInfo>(item.Data, _serializerOptions)!);
        }

        public CompanyInfo? GetCompanyInfoById(string cikId)
        {
            // Get persisted data
            using var scope = _serviceProvider.CreateScope();
            var _dbContext = scope.ServiceProvider.GetRequiredService<ForaFinDbContext>();
            _logger.LogInformation("Retrieving item from database {0}", cikId);

            var cikItem = _dbContext.CikItems.SingleOrDefault(item => item.Key == cikId);
            return cikItem is not null
                ? JsonSerializer.Deserialize<CompanyInfo>(cikItem.Data, _serializerOptions)
                : null;
        }

    }
}
