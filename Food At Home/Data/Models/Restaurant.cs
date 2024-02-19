using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_At_Home.Data.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            this.Orders = new List<Order>();
            this.Menu = new List<Dish>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public string? Description { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Dish> Menu { get; set; }


    }
}
