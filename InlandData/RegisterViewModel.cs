using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class RegisterViewModel
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter a UserName")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please Enter a password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please retype a password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password does not match.")]

        public string? ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "Please Enter a First and Last name")]

        //public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter an email address")]
        [DataType(DataType.EmailAddress)]

        public string? Email { get; set; }

        //[Required(ErrorMessage = "Please Enter a password")]

        //public int? CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter a First Name")]

        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter a Last Name")]
        [StringLength(50, ErrorMessage = "Please Enter a last name with a maximum 50 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please Enter a phone number")]
        [StringLength(12, ErrorMessage = "Please Enter a 9 digit phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter a city name")]
        [StringLength(50, ErrorMessage = "Please Enter a name with a maximum 50 characters")]
        public string City { get; set; }
    }
}
