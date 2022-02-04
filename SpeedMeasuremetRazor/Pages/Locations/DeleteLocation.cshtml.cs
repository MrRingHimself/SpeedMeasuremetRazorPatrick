using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeedMeasuremetRazor.Interfaces;
using SpeedMeasuremetRazor.Models;

namespace SpeedMeasuremetRazor.Pages.Locations
{
    public class DeleteLocationModel : PageModel
    {
        public ILocationRepo Local;

        [BindProperty]
        public Location Location { get; set; }

        public DeleteLocationModel(ILocationRepo locationRepo)
        {
            Local = locationRepo;
        }

        public IActionResult OnGet(int id)
        {
            Location = Local.GetLocation(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            Local.DeleteLocation(Location.LocationId);
            return RedirectToPage("Index");
        }
    }
}
