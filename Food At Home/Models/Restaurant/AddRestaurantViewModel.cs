using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models.Restaurant
{
    public class AddRestaurantViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(40)]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string PasswordRepeat { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Address { get; set; } = null!;


        public IFormFile? ProfilePicture { get; set; }
    }
}
