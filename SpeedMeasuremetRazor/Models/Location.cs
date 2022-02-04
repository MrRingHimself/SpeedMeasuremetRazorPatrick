using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SpeedMeasuremetRazor.Models
{
    public class Location
    {
        private int _locationId;

        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _speedLimit;

        public int SpeedLimit
        {
            get { return _speedLimit; }
            set { _speedLimit = value; }
        }

        public Zone Zone { get; set; }


        public Location()
        {
            
        }
        public Location(int locationId, string address, int speedLimit, Zone zone)
        {
            _locationId = locationId;
            _address = address;
            _speedLimit = speedLimit;
            Zone = zone;
        }

        public override string ToString()
        {
            return $"Placerings Id: {_locationId}, Placerings addresse: {_address}, Placerings fart grænse: {_speedLimit}";
        }
    }
}
