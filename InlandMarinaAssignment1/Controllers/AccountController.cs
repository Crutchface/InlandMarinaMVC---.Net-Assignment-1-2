using InlandData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InlandMarinaAssignment1.Controllers
{
    public class AccountController : Controller
    {   
        // Identity object to manage the signin
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        // For DB Stufff
        InlandContext _context;
      
  
        // Replaces manager classes and DI's inlandcontext
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager,InlandContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            _context = context;
           
        }

        public IActionResult Login()
        {
            ViewBag.Page = "Login";
            return View();
        }
        // Post for login
        [HttpPost] 
        public async Task<IActionResult> LoginAsync(LoginViewModel loginModel)
        {
            if (ModelState.IsValid) // Checks our models validity
            {   
                // Authenticates signin 
                var result = await signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, loginModel.RememberMe, false);
                // If successful redirect to home 
                if (result.Succeeded) 
                {   
                    return RedirectToAction("Index", "Home");
                }  
                // Otherwise reload the page
                else
                {
                    ModelState.AddModelError("", "Invalid Login");
                    return View();
                }
            }
            //Reloads the page if the model is not valid
            return View();
        }

        public IActionResult Register()
        {
            ViewBag.Page = "Register";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel registerModel)
        {   
            ViewBag.Page = "Register";
            if (ModelState.IsValid) 
            {
                Customer newCustomer = new Customer()
                {
                    FirstName = registerModel.FirstName,
                    LastName = registerModel.LastName,
                    Phone = registerModel.Phone,
                    City = registerModel.City

                };
                // Get last Id from customer table 
                CustomerManager.AddCustomer(_context, newCustomer);
                int lastId = CustomerManager.GetLastId(_context);
               
                // Add a new user 
                User newUser = new User()
                {
                    UserName = registerModel.FirstName[0].ToString().ToLower() + registerModel.LastName.ToLower(),
                    //UserName = registerModel.Username,
                    Email = registerModel.Email,
                    Name = registerModel.FirstName!,
                    CustomerId = lastId,  // Assign the generated CustomerId
                    PhoneNumber = registerModel.Phone    
                    
                };
                var userResult = await userManager.CreateAsync(newUser, registerModel.Password);
                if (userResult.Succeeded ) 
                { 
                    await signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                
                }
                foreach (var item in userResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
               


            }

            return View();
        }


        public async Task<IActionResult> LogoutAsync()
        {   
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
