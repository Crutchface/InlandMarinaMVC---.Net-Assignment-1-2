using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandData
{
    public class DockManager
    {   
        // Gets a list of all our docks 
        public static List<Dock> GetAllDocks(InlandContext db) 
        { 
            return db.Docks.ToList();
        
        }

    }
}
