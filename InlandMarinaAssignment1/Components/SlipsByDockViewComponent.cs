using Microsoft.AspNetCore.Mvc;
using InlandData;

namespace InlandMarinaAssignment1.Components
{
    public class SlipsByDockViewComponent : ViewComponent
    {
        // Dependency injection
        private InlandContext _context;

        public SlipsByDockViewComponent(InlandContext inlandContext)
        {
            this._context = inlandContext;
        }

        // Creates an invoke method for calling
        public async Task<IViewComponentResult> InvokeAsync(int dockId)
        {
            List<Slip> slips;
            if(dockId == 5) // Returns all slips
            {
                slips = SlipManager.GetSlips(_context);
            }
            else // return by dock
            {
                slips = SlipManager.GetSlipsByDock(_context, dockId);
            }
            return View(slips); // Calls the DEFAULT view cs in the shared folder inside views

        }
    }
}
