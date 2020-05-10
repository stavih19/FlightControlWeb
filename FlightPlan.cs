using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FlightControlWeb
{
    public class FlightPlan
    {
        int passengers;
        string company_name;
        InitialLocation initialLocation;
        Segment[] segments;

        public FlightPlan(int passengers, string company_name,InitialLocation initialLocation,Segment[] segments)
        {
            this.passengers = passengers;
            this.company_name = company_name;
            this.initialLocation = initialLocation;
            this.segments = segments;
        }

        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public string Company
        {
            get { return company_name; }
            set { company_name = value; }
        }
        public InitialLocation InitialLocation
        {
            get { return initialLocation; }
        }
        public Segment[] Segments
        {
            get { return segments; }
            set { segments = value; }
        }
    }
}
