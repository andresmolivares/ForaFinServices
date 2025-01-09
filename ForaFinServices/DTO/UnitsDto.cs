namespace ForaFinServices.DTO
{
    public class UnitsDto
    {
        public List<FinancialUnitDto>? Shares { get; set; }
        
        public List<FinancialUnitDto>? USD { get; set; }
        
        public List<FinancialUnitDto>? Pure { get; set; }
        
        public List<FinancialUnitDto>? USDShares { get; set; }
        
        public List<FinancialUnitDto>? Employee { get; set; }
        
        public List<FinancialUnitDto>? Y { get; set; }
        
        public List<FinancialUnitDto>? Lawsuit { get; set; }
        
        public List<FinancialUnitDto>? Plaintiff { get; set; }
        
        public List<FinancialUnitDto>? Patent { get; set; }

        //NOTE: Alternative attribute: segement
        public List<FinancialUnitDto>? Segment { get; set; }

        //NOTE: Alternative attribute: reporting_unit
        public List<FinancialUnitDto>? ReportingUnit { get; set; }

        public List<FinancialUnitDto>? DerivativeAgreement { get; set; }
    }
}
