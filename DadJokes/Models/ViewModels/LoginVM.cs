﻿using System.ComponentModel.DataAnnotations;

namespace DadJokes.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
        [Display(Name = "Remember me!!")]
        public bool RememberMe { get; set;}
    }
}
