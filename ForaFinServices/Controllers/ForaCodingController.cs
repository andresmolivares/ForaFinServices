using ForaFinServices.DTO;
using ForaFinServices.Handlers.Messages;
using ForaFinServices.Services;
using ForaFinServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ForaFinServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForaCodingController : ControllerBase
    {
        private readonly ILogger<ForaCodingController> _logger;
        private readonly IFundableAmountService _service;
        private readonly QueueService _queueService;

        public ForaCodingController(ILogger<ForaCodingController> logger, IFundableAmountService service, QueueService queueService)
        {
            _logger = logger;
            _service = service;
            _queueService = queueService;
        }

        [HttpPut(Name = "LoadCompanyInfo")]
        [Description("Loads company info data from the CIKS source")]
        public void Load()
        {
            try
            {
                _queueService.PublishMessage(new LoadDataMessage());
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller Load: {0}", e);
                throw;
            }

        }

        [HttpGet()]
        [Description("Get fundable data for filtered company info data")]
        public IEnumerable<FundableAmountDto> Get(string? letterFilter)
        {
            try
            {
                return _service.GetFundableAmount(letterFilter)
                    .Where(f => f is not null)
                    .OrderBy(f => f.Name);
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller Get: {0}", e);
                throw;
            }

        }

        [HttpGet("{cikId}")]
        [Description("Get fundable data for specified company info")]
        public FundableAmountDto? GetSingleFundableAmount(string cikId)
        {
            try
            {
                if(!long.TryParse(cikId, out var id))
                    throw new Exception($"Invalid cikId value: {cikId}");
                return _service.GetSingleFundableAmount(cikId);
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller GetSingleFundableAmount: {0}", e);
                throw;
            }

        }
    }
}
