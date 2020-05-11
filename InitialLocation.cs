using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb
{
    public class InitialLocation
    {
        double longitude;
        double latitude;
        string date_time;

        public InitialLocation(double longitude, double latitude, string date_time)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.date_time = date_time;
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public string Date_time
        {
            get { return date_time; }
            set { date_time = value; }
        }
    }
}
