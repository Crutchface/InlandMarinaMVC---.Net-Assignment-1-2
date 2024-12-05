using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class CustomerManager
    {
        public static void AddCustomer(InlandContext db, Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public static int GetLastId(InlandContext db)
        {
            var lastCustomer = db.Customers
                .OrderByDescending(c => c.CustomerId) // Order by CustomerId in descending order
                .FirstOrDefault(); // Get the first customer (which will be the one with the highest ID)

            int lastCustomerId = lastCustomer?.CustomerId ?? 0; // If lastCustomer is null, return 0

            return lastCustomerId;
        }
    }
}
