using Humanizer.Localisation;
using InlandData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;

namespace InlandMarinaAssignment1.Controllers
{
    public class SlipController : Controller
    {
        // Stores info from Inland context in _contextused within a class to hold a reference
        // to the instance of the
        // InlandContext that you interact with in methods to perform database operations. 
        InlandContext _context;

        //This is the constructor for the SlipController class. 
        //The constructor takes a single parameter, InlandContext context, which represents
        //an instance of the InlandContext class, a class that
        //inherits from DbContext in Entity Framework(EF) Core and is responsible for managing
        //database operations
        public SlipController(InlandContext context)
        {
            _context = context;
        }  
        // GET: SlipController : Our endpoint for returning views for all slips (Not used)
        public ActionResult Index()
        {
            List<Slip> slips = SlipManager.GetSlips(_context);
            return View(slips);
        }


        // Get for filtering Slips by dock: Endpoint to filter slips based on the dock they are in 

        public ActionResult FilteredSlips()
        {
            ViewBag.Page = "Slips";
            // Makes a list of select list items from the get docks function underneath
            List<SelectListItem> docks = GetDocks();
            // Makes a list of all the slips we have. We send the context info for the EF dependency injection
            List<Slip> slips = SlipManager.GetSlips(_context);
            // Store the docks select list item in the viewbag
            ViewBag.Dock = docks;
            // returns the view using the model of slips 
            return View(slips);
        }
        // Created function to return a selection list of all docks
        private List<SelectListItem> GetDocks()
        {
            // get list of genres 
            List<Dock> docks = DockManager.GetAllDocks(_context);
            // create a select / dropdown list of genres 
            var list = new SelectList(docks, "DockId", "Name").ToList();
            // ensure that a genre is not slected first so as to see all movies 
            list.Insert(0, new SelectListItem("Select a Dock", "5"));
            // Stores the list of genres into the viewbag
            return list;
        }

        // THE POST FUNCTIOn: for our filtered list triggered by the select box on the page.
        // Sets our default as 5, what we set as the selection id for the "Select Dock" added item
        [HttpPost]
        public ActionResult FilteredSlips(string id = "5")
        {
            ViewBag.Page = "Slips";
            // Makes a select box of all docks again 
            List<SelectListItem> list = GetDocks();
            // Stores it in the viewbag 
            ViewBag.Dock = list;
            // Cycle through the list returned 
            foreach(var item in list)
            {   
                // If the item value of that item is the same as the one we fed it
                if(item.Value == id)
                {   
                    // Selects the item in the list when the page is loaded 
                    item.Selected = true;
                    // Breaks the loop
                    break;
                }
            }
            // Then Makes a list of slips 
            List<Slip> slips;
            // stores data in slips based on a terneray operator.
            // If its still 5 (our default) just load the page regularly.
            // If its Not, calls our GetSlipsByDock function in slip manager.
            // Feeding it the context for ef database use and the id number (converted)
            slips = id == "5" ? SlipManager.GetSlips(_context) : SlipManager.GetSlipsByDock(_context, Convert.ToInt32(id));
            return View(slips);
        }

       
        // GET: SlipController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SlipController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SlipController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SlipController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SlipController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SlipController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SlipController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BookSlip(int id)
        {
            Slip? slip = SlipManager.GetSlipById(_context, id);

                
            return View(slip);
        }
    }
}
