namespace ForaFinServices.DTO
{
    public class CompanyInfoHeaderDto
    {
        public long? Cik { get; set; }
        public string? Name { get; set; }
        public FactsDto? Facts { private get; set; }
        public bool HasDeiFacts => Facts?.Dei is not null;
        public bool HasUsGaapFacts => Facts?.UsGaap is not null;
    }
}
