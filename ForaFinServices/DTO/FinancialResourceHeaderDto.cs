namespace ForaFinServices.DTO
{
    public class FinancialResourceHeaderDto
    {
        public string? Label { get; set; }
        public string? Description { get; set; }
        public UnitsDto? Units { private get; set; }
        public bool HasDerivativeAgreements => Units is not null && Units.DerivativeAgreement is not null && Units.DerivativeAgreement.Any();
        public bool HasEmployees => Units is not null && Units.Employee is not null && Units.Employee.Any();
        public bool HasLawsuits => Units is not null && Units.Lawsuit is not null && Units.Lawsuit.Any();
        public bool HasPatents => Units is not null && Units.Patent is not null && Units.Patent.Any();
        public bool HasPlaintiffs => Units is not null && Units.Plaintiff is not null && Units.Plaintiff.Any();
        public bool HasPures => Units is not null && Units.Pure is not null && Units.Pure.Any();
        public bool HasReportingUnits => Units is not null && Units.ReportingUnit is not null && Units.ReportingUnit.Any();
        public bool HasSegments => Units is not null && Units.Segment is not null && Units.Segment.Any();
        public bool HasShares => Units is not null && Units.Shares is not null && Units.Shares.Any();
        public bool HasUSDs => Units is not null && Units.USD is not null && Units.USD.Any();
        public bool HasUSDShares => Units is not null && Units.USDShares is not null && Units.USDShares.Any();
        public bool HasYs => Units is not null && Units.Y is not null && Units.Y.Any();
    }
}
