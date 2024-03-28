using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models
{
    public class PaymentFormModel
    {
        public decimal Amount { get; set; }

        [Required]
        [StringLength(19)]
        public string CardNumber { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string CardHolder { get; set; } = null!;

        [Required]
        public string ExpiryDate { get; set; } = null!;

        [Required]
        [StringLength(4)]
        public string SecurityCode { get; set; } = null!;

        public Guid RestaurantId { get; set; }
    }
}
