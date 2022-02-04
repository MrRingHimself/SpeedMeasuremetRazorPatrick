using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

using SpeedMeasuremetRazor.Helpers;
using SpeedMeasuremetRazor.Interfaces;
using SpeedMeasuremetRazor.Models;

namespace SpeedMeasuremetRazor.Services
{
    public class LocationRepo : ILocationRepo
    {
        public List<Location> locations { get; }

        public LocationRepo()
        {
            locations = MockData.Locations;
        }

        public List<Location> GetAllLocations()
        {
            return locations;
        }

        public void AddLocation(Location location)
        {
            if (GetLocation(location.LocationId) == null)
            {
                locations.Add(location);
            }
        }

        public void UpdateLocation(Location location)
        {
            if (location != null)
            {
                foreach (Location local in locations)
                {
                    if (local.LocationId == location.LocationId)
                    {
                        local.LocationId = location.LocationId;
                        local.Address = location.Address;
                        local.SpeedLimit = location.SpeedLimit;
                    }
                }
            }
        }

        public Location GetLocation(int id)
        {
            foreach (Location local in locations)
            {
                if (local.LocationId == id)
                {
                    return local;
                }
            }

            return null;
        }

        public void DeleteLocation(int id)
        {
            if (GetLocation(id) != null )
            {
                locations.Remove(GetLocation(id));
            }

        }

        
    }
}
