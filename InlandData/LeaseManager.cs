using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class LeaseManager
    {   

        public static List<Lease> GetMyLease(InlandContext db, int userId)
        {
            // where clause to specify which slips are returned 
            return db.Leases.Where(s => s.CustomerID == userId).ToList();
        }

        public static void NewLease(InlandContext db, int slipId, int customerId)
        {   
            Lease newLease = new Lease();
            newLease.SlipID = slipId;
            newLease.CustomerID = customerId;
            db.Leases.Add(newLease);
            db.SaveChanges();
        }
    }
}
