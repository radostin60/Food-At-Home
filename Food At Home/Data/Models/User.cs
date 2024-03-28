using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Data.Models
{
    public class User:IdentityUser<Guid>
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(80)]
        public string Address { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}
