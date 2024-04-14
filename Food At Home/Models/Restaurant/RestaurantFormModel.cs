using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models.Restaurant
{
    public class RestaurantFormModel
    {
        public Guid Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(600)]
        public string? Description { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(80)]
        public string Address { get; set; } = null!;


    }
}
