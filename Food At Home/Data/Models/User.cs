using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Data.Models
{
    public class User:IdentityUser
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        public string? ImgageUrl { get; set; }
    }
}
