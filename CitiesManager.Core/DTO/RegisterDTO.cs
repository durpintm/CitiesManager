using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesManager.Core.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Person Name can't be blank")]
        public string PersonName { get; set; } = null!;

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be in a proper email address format")]
        [Remote("IsEmailAlreadyRegistered", "Account", ErrorMessage = "Email already in use")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone Number can't be blank")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number should contain digits only")]
        public string PhoneNumber { get; set; } = null!;


        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirm Password can't be blank")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; } = null!;


    }
}
