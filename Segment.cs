using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb
{
    public class Segment
    {
        double longitude;
        double latitude;
        double timespan_seconds;

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
        public double Timespan_seconds
        {
            get { return timespan_seconds; }
            set { timespan_seconds = value; }
        }

        public Segment(double longitude, double latitude, double timespan_seconds)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.timespan_seconds = timespan_seconds;
        }
    }
}
