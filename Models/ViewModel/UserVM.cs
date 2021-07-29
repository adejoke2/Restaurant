using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models.ViewModel
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }

    public class CreateUserViewModel
    {
        internal string firstname;

        [Required(ErrorMessage = "User name is required")]
        [Display(Name = "User Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User E-mail is required")]
        [Display(Name = "E-mail Address:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password!!")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender:")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please! Pick a Type")]
        [Display(Name = "Type:")]
        public string Type { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [Display(Name = "PhoneNumber:")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address:")]
        public string Address { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [Display(Name = "LastName:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [Display(Name = "FirstName:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "userId is required")]
        [Display(Name = "userId:")]
        public int userId { get; set; }

        [Required(ErrorMessage = "userEmail is required")]
        [Display(Name = "userEmail:")]
        public string userEmail { get; set; }

        [Required(ErrorMessage = "User name is required")]
        [Display(Name = "Id:")]
        public int Id { get; set; }


    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "User E-mail is required")]
        [Display(Name = "E-mail Address:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Password is required")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }
}
