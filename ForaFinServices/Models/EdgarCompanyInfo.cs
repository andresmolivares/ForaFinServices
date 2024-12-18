namespace ForaFinServices.Models
{
    public class EdgarCompanyInfo
    {
        /// <summary>
        /// Updated type to object due to inconsistent source data type. Values were either string or number.
        /// </summary>
        public object Cik { get; set; }
        public string EntityName { get; set; }
        public InfoFact Facts { get; set; }
    }
}
