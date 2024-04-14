using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models
{
    public class EditProfileModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(30)]
        public string Email { get; set; } = null!;


        [Required]
        public string PhoneNumber { get; set; } = null!;

        //[Required]
        //[StringLength(20)]
        //public string Country { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(80)]
        public string Address { get; set; } = null!;


        public IFormFile? ImageUrl { get; set; }
    }
}
