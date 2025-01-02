namespace ForaFinServices.DTO
{
    public class CompanyInfoDto
    {
        public long? Cik { get; set; }
        public string? Name { get; set; }
        public FactsDto? Facts { private get; set; }
        public bool HasDeiFacts => Facts?.Dei is not null;
        public bool HasUsGaapFacts => Facts?.UsGaap is not null;
    }


    public class CompanyInfoDetailsDto
    {
        public long? Cik { get; set; }
        public string? Name { get; set; }
        public FactsDto? Facts { get; set; }
    }

}
