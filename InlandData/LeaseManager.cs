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
            return db.Leases.Where(s => s.LeaseId == userId).ToList();
        }
    }
}
