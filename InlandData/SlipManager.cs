using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class SlipManager
    {   
        // Function to return a list of slips and lazy loading in docks as well to display the name of the dock instead of ID 
        public static List<Slip> GetSlips(InlandContext db)
        {
            // Using inland context for dependency injection
            return db.Slips
                .Include(d => d.Dock)
                .Where(s => !db.Leases.Select(l => l.SlipID).Contains(s.SlipId))
                .ToList();
        }
        // Function to get a list based on the dock ID provided 
        public static List<Slip> GetSlipsByDock(InlandContext db, int dockId)
        {   
            // where clause to specify which slips are returned 
            return db.Slips.Where(s => s.DockID == dockId).ToList();
        }

        public static Slip? GetSlipById(InlandContext db, int id) 
        {
            return db.Slips.Find(id);
        }
     

    }
}
