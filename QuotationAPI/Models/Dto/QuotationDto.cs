namespace QuotationAPI.Models.Dto
{
    public class QuotationDto
    {
        public Guid QuotationNumber { get; set; }
        public string PolicyOwner { get; set; } = string.Empty;
        public string CarMake { get; set; } = string.Empty;
        public int CarYearOfMake { get; set; }
        public Quotation.QStatus QuotationStatus { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
