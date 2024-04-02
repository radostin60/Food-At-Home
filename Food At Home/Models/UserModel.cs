using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        //[Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        //public string City { get; set; }

        public string Address { get; set; }

        public string? ProfilePictureUrl { get; set; }
    }
}
