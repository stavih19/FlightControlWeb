using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FlightControlWeb
{
    public class FlightPlanItem
    {
        double flight_id;
        double longitude;
        double latitude;
        int passengers;
        string company_name;
        string date_time;
        bool is_external;
        Segment[] segments;

        public FlightPlanItem(double flight_id, double longitude, double latitude, int passengers, string company_name, string date_time, bool is_external)
        {
            this.flight_id = flight_id;
            this.longitude = longitude;
            this.latitude = latitude;
            this.passengers = passengers;
            this.company_name = company_name;
            this.date_time = date_time;
            this.is_external = is_external;
            segments = new Segment[0];
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
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public string Date_time
        {
            get { return date_time; }
            set { date_time = value; }
        }
        public Segment[] Segments
        {
            get { return segments; }
            set { segments = value; }
        }
    }
}
