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
    public class EditLocationModel : PageModel
    {
        private ILocationRepo _local;

        [BindProperty]
        public Location Location { get; set; }

        public EditLocationModel(ILocationRepo locat)
        {
            _local = locat;
        }

        public IActionResult OnGet(int id)
        {
            Location = _local.GetLocation(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _local.UpdateLocation(Location);
            return RedirectToPage("Index");
        }

    }
}
