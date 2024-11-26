using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class Lease
    {
        public int LeaseId {  get; set; }

        [Required(ErrorMessage = "Please Enter a Slip Id")]
        public int SlipID { get; set; }

        [Required(ErrorMessage = "Please Enter customer Id")]
        public int CustomerID { get; set; }

        public Slip? Slip { get; set; }
        public Customer? Customer { get; set; }
    }
}
