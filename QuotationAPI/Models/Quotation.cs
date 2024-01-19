using System.ComponentModel.DataAnnotations;

namespace QuotationAPI.Models
{
    public class Quotation
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PolicyOwnerId { get; set; }
        public PolicyOwner PolicyOwner { get; set; }

        public Car Car { get; set; }

        public QStatus QuotationStatus { get; set; }
        public DateTime CreationDate { get; set; }

        public enum QStatus
        {
            Draft,
            Purchased
        }

    }
}
