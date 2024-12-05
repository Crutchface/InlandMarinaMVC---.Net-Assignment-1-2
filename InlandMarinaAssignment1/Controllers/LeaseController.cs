using InlandData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InlandMarinaAssignment1.Controllers
{
    public class LeaseController : Controller
    {   
        InlandContext _context;
        private readonly UserManager<User> userManager;

        public LeaseController(InlandContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        public async Task<ActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                // Handle case where the user is not found (logged-out or invalid session)
                return RedirectToAction("Login", "Account");
            }
            int customerId = Convert.ToInt32(user.CustomerId);
            List<Lease> leased = LeaseManager.GetMyLease(_context, customerId);
            return View(leased);
        }

     

    }
}
