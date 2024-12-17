namespace ForaFinServices.Models
{
    public class FundableAmountResponse
    {
        public required object Id { get; set; }
        public string? Name { get; set; }
        public required decimal StandardFundableAmount { get; set; }
        public required decimal SpecialFundableAmount { get; set; }
    }
}
