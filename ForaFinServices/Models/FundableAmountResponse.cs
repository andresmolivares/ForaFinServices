namespace ForaFinServices.Models
{
    public class FundableAmountResponse
    {
        public object Id { get; set; }
        public string? Name { get; set; }
        public decimal StandardFundableAmount { get; set; }
        public decimal SpecialFundableAmount { get; set; }
    }
}
