using System.ComponentModel.DataAnnotations;

namespace QuotationAPI.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        public string Make { get; set; } = string.Empty;
        public int YearOfMake { get; set; }

        public Guid QuotationId { get; set; }
        public virtual Quotation Quotation { get; set; }

    }
}
