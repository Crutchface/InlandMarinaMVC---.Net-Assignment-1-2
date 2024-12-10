using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please Enter a First Name")]
        [StringLength(30, ErrorMessage = "Please Enter a name with a maximum 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter a Last Name")]
        [StringLength(30, ErrorMessage = "Please Enter a last name with a maximum 50 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter a phone number")]
        [StringLength(12, ErrorMessage = "Please Enter a 9 digit phone number")]
        [RegularExpression("^(\\+0?1\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$", ErrorMessage = "Please Enter a valid phone number")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "Please Enter a city name")]
        [StringLength(50, ErrorMessage = "Please Enter a name with a maximum 50 characters")]
        public string City { get; set; }

    }
}
