﻿using ForaFinServices.Extensions;
using ForaFinServices.Models;
using ForaFinServices.Services.Interfaces;

namespace ForaFinServices.Services
{
    public class CompanyInfoQueryService : ICompanyInfoQueryService
    {
        private readonly ILogger<CompanyInfoQueryService> _logger;
        private readonly ICompanyInfoCacheService _companyInfoCacheService;
        

        public CompanyInfoQueryService(
            ILogger<CompanyInfoQueryService> logger,
            ICompanyInfoCacheService companyInfoCacheService)
        {
            _companyInfoCacheService = companyInfoCacheService;
            _logger = logger;
        }

        public IEnumerable<CompanyInfo> GetCompanyInfoList()
        {
            return _companyInfoCacheService.GetCompanyInfoList();
        }

        public CompanyInfo? GetCompanyInfo(long cikId)
        {
            return _companyInfoCacheService.GetCompanyInfoById(cikId.ToString());
        }

        public BaseFinancialResource? GetCompanyInfoResource(long cikId, string resourceType)
        {
            var companyInfo = _companyInfoCacheService.GetCompanyInfoById(cikId.ToString());
            return companyInfo?.GetFinancialResource(resourceType);
        }
    }
}