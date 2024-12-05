using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class User: IdentityUser
    {
        public int Id { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        // Stoes info from customer
        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
