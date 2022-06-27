﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter your Name")]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be longer than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
