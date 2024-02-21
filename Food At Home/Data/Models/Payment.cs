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
        public string CardNumber { get; set; } = null!;

        [Required]
        public string SecurityCode { get; set; } = null!;

        [Required]
        public string CardHolder { get; set; } = null!;

        [Required]
        [Precision(4,2)]
        public decimal Amount { get; set; }

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
