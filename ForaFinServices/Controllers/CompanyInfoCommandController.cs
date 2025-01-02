using ForaFinServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ForaFinServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyInfoCommandController : ControllerBase
    {
        private readonly ILogger<CompanyInfoCommandController> _logger;
        private readonly IFundableAmountService _service;

        public CompanyInfoCommandController(ILogger<CompanyInfoCommandController> logger, IFundableAmountService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpDelete()]
        [Description("")]
        public async Task Delete(string? letterFilter)
        {
            await Task.Yield();
        }
    }
}
