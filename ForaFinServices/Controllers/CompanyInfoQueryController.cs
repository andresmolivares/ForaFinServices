using AutoMapper;
using ForaFinServices.DTO;
using ForaFinServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ForaFinServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyInfoQueryController : ControllerBase
    {
        private readonly ILogger<CompanyInfoQueryController> _logger;
        private readonly ICompanyInfoQueryService _service;
        private readonly IMapper _mapper;

        public CompanyInfoQueryController(
            ILogger<CompanyInfoQueryController> logger, 
            ICompanyInfoQueryService service,
            IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        [HttpGet()]
        [Description("Get loaded company info list items")]
        public IEnumerable<CompanyInfoHeaderDto> GetList()
        {
            try
            {
                var result = _service.GetCompanyInfoList()
                    .Where(f => f is not null)
                    .OrderBy(f => f.EntityName);
                return _mapper.Map<IEnumerable<CompanyInfoHeaderDto>>(result);
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller GetList: {0}", e);
                throw;
            }
        }

        [HttpGet("{cikId}")]
        [Description("Get loaded company info details")]
        public CompanyInfoDto GetCompanyInfo(string cikId)
        {
            try
            {
                if(!long.TryParse(cikId, out var id))
                    throw new Exception($"Invalid cikId value: {cikId}");
                return _mapper.Map<CompanyInfoDto>(_service.GetCompanyInfo(id));
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller GetCompanyInfo: {0}", e);
                throw;
            }
        }


        [HttpGet("{cikId}/{resourceType}/units")]
        [Description("Get loaded company info list items")]
        public FinancialResourceDto GetCompanyInfoResource(string cikId, string resourceType)
        {
            try
            {
                if(!long.TryParse(cikId, out var id))
                    throw new Exception($"Invalid cikId value: {cikId}");
                return _mapper.Map<FinancialResourceDto>(_service.GetCompanyInfoResource(id, resourceType));
            }
            catch(Exception e)
            {
                _logger.LogError("Error occurred in controller GetCompanyInfo: {0}", e);
                throw;
            }
        }
    }
}
