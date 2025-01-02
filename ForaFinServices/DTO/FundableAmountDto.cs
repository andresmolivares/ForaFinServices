namespace ForaFinServices.DTO
{
    /// <summary>
    /// Represents a response for a company with calculated fundable amounts.
    /// </summary>
    public class FundableAmountDto
    {
        public object Id { get; set; }
        public string? Name { get; set; }
        public decimal StandardFundableAmount { get; set; }
        public decimal SpecialFundableAmount { get; set; }
    }

}
