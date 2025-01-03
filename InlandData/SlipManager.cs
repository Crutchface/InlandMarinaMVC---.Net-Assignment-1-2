﻿using Microsoft.EntityFrameworkCore;
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
            // Get the list of leased SlipIds
            var leasedSlipIds = db.Leases.Select(l => l.SlipID).ToList();

            // Return the slips that match the dockId and are not leased
            return db.Slips
                .Where(s => s.DockID == dockId && !leasedSlipIds.Contains(s.SlipId)) // Exclude leased slips
                .Include(s => s.Dock)
                .ToList();
        }

        public static Slip? GetSlipById(InlandContext db, int id) 
        {
            return db.Slips.Find(id);
        }
     

    }
}
