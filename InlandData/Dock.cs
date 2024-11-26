using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class Dock
    {   
        public int DockId { get; set; }
        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter true or false")]
        public bool WaterService { get; set; }
        [Required(ErrorMessage = "Please enter true or false")]
        public bool ElectricalService { get; set; }

    }
}
