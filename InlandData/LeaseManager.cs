using Microsoft.EntityFrameworkCore;
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
            return db.Leases
                        .Where(l => l.CustomerID == userId)
                        .Include(l => l.Slip)  // Include the related Slip for each Lease
                        .ThenInclude(s => s.Dock)
                         .OrderBy(l => l.Slip.SlipId)// Include the related Dock for each Slip
                        .ToList();
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
