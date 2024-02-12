﻿using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Data.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
