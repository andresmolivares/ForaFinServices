using ForaFinServices.Models;
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

        public ForaCodingController(ILogger<ForaCodingController> logger, IFundableAmountService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPut(Name = "LoadCompanyInfo")]
        [Description("Loads company info data from the CIKS source")]
        public async Task Load()
        {
            try
            {
                await _service.PersistData();
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller Get: {0}", e);
                throw;
            }

        }

        [HttpGet()]
        [Description("Get fundable data for loaded company info data")]
        public IEnumerable<FundableAmountResponse> Get(string? letterFilter)
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
    }
}
