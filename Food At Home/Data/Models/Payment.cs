using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_At_Home.Data.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(19)]
        public string CardNumber { get; set; } = null!;

        [Required]
        [StringLength(4)]
        public string SecurityCode { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string CardHolder { get; set; } = null!;

        [Required]
        [Precision(4,2)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime ExpiryDate {  get; set; }

        [Required]
        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } 
    }
}
