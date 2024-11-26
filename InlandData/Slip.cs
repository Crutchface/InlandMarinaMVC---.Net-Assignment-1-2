using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class Slip
    {   
        // attribute to change display property of slip id using metadata
        [Display(Name = "Slip Number")]
        public int SlipId {  get; set; }
        // attribute for serverside validation 
        [Required(ErrorMessage = "Please Enter a Width")]
        // Attribute for the range of the input
        [Range(9, 12, ErrorMessage = "Please enter a width between 9 and 12 ft")]
       
        public decimal Width { get; set; }
        // Attribute for length with required and range 
        [Required(ErrorMessage = "Please Enter a Length")]
        [Range(16, 32, ErrorMessage = "Please enter a value between 16 and 32 ft")]
        public decimal Length { get; set; }
        // Attribute for changing name of DockId to dock name via metadata
        [Display(Name ="Dock Name")]
        public int DockID { get; set; }

        public Dock? Dock { get; set; }
    }
}
