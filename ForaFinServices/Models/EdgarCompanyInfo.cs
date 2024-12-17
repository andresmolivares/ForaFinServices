namespace ForaFinServices.Models
{
    public class EdgarCompanyInfo
    {
        /// <summary>
        /// Updated type to object due to inconsistent source data type. Values were either string or number.
        /// </summary>
        public required object Cik { get; set; }
        public required string EntityName { get; set; }
        public required InfoFact Facts { get; set; }
    }
}
