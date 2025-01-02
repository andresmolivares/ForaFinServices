namespace ForaFinServices.DTO
{
    public class FinancialResourceHeaderDto
    {
        public string? Label { get; set; }
        public string? Description { get; set; }
        public UnitsDto? Units { private get; set; }
        public bool HasUnits => Units is not null && Units.USD is not null;
    }


    public class FinancialResourceDto
    {
        public string? Label { get; set; }
        public string? Description { get; set; }
        public UnitsDto? Units { get; set; }
    }

}
