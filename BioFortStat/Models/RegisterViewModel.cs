using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Role Name")]
        public string Users { get; set; }

        [Required (ErrorMessage = "Enter values Between 0 -9, a capital letter and other alphabet Greater than 12 values.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Passwords must have at least one non letter or digit character. Passwords must have at least one uppercase ('A'-'Z').")]

        [StringLength(100, ErrorMessage = "Passwords must have at least one non letter or digit character. Passwords must have at least one uppercase ('A'-'Z').", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}