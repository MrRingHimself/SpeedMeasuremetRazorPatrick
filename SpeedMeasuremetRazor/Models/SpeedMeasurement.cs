using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedMeasuremetRazor.Models
{
    public class SpeedMeasurement
    {
        private int _spMeId;

        public int SpMeId
        {
            get { return _spMeId; }
            set { _spMeId = value; }
        }

        private DateTime _timeStamp;

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private string _imageName;

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public SpeedMeasurement(int spMeId, DateTime timeStamp, int speed, string imageName)
        {
            _spMeId = spMeId;
            _timeStamp = timeStamp;
            _speed = speed;
            _imageName = imageName;
        }

        public override string ToString()
        {
            return $"Fart måling Id: {_spMeId}, Målingens Time Stamp: {_timeStamp}, Fart måling: {_speed}, Billed navn: {_imageName}";
        }
    }
}
