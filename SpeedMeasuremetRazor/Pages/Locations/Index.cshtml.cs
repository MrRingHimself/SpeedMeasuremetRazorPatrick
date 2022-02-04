using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeedMeasuremetRazor.Interfaces;
using SpeedMeasuremetRazor.Models;
using SpeedMeasuremetRazor.Services;

namespace SpeedMeasuremetRazor.Pages.Locations
{
    public class IndexModel : PageModel
    {
        private ILocationRepo _local;

        public List<Location> Locals { get; private set; }

        public IndexModel(ILocationRepo catalog)
        {
            _local = catalog;
        }

        public void OnGet()
        {
            Locals = _local.GetAllLocations();
        }
    }
}
