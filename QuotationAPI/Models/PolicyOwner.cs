using System.ComponentModel.DataAnnotations;

namespace QuotationAPI.Models
{
    public class PolicyOwner
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public virtual ICollection<Quotation>? Quotations { get; set; }

    }
}
