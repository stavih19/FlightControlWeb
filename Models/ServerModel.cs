using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public sealed class ServerModel
    {
        private static readonly ServerModel instance = new ServerModel();

        static ServerModel() { }

        private ServerModel()
        {
            // run the server
        }

        public static ServerModel Instance
        {
            get { return instance; }
        }

        List<ExternalServerModel> externalServerModels;
        List<Flight> flightsList = new List<Flight>();
        int port;
        string ipAdress = "127.0.0.1";

        public string IpAdress
        {
            get { return ipAdress; }
            set { ipAdress = value; }
        }

        public List<ExternalServerModel> ExternalServerModels
        {
            get { return externalServerModels; }
            set { externalServerModels = value; }
        }

        public void AddExternalServer(string newSrverURL)
        {
            int newID = externalServerModels.Count + 1;
            externalServerModels.Add(new ExternalServerModel(newID, newSrverURL));
        }

        public void DeleteExternalServer(int id)
        {
            foreach (ExternalServerModel temp in externalServerModels)
            {
                if (temp.Server_id == id)
                {
                    externalServerModels.Remove(temp);
                    break;
                }
            }
        }

        public List<Flight> GetFlights(string relative_to, bool isExternals)
        {
            DateTime flightTime;
            DateTime relateTime = ConvertToDateTime(relative_to);
            List<Flight> flightToSend = null;
            if (isExternals)
            {
                foreach (Flight flight in flightsList)
                {
                    flightTime = ConvertToDateTime(relative_to);
                    if (DateTime.Compare(relateTime, flightTime) <= 0)
                    {
                        flightToSend.Add(flight);
                    }
                }
            }
            else
            {
                foreach (Flight flight in flightsList)
                {
                    flightTime = ConvertToDateTime(relative_to);
                    if ((DateTime.Compare(relateTime, flightTime) <= 0) && (!flight.Is_external))
                    {
                        flightToSend.Add(flight);
                    }
                }
            }


            return flightToSend;
        }

        public DateTime ConvertToDateTime(string relative_to)
        {
            int year = Int32.Parse(relative_to.Substring(0, 4));
            int mounth = Int32.Parse(relative_to.Substring(5, 2));
            int day = Int32.Parse(relative_to.Substring(8, 2));
            int hour = Int32.Parse(relative_to.Substring(11, 2));
            int min = Int32.Parse(relative_to.Substring(14, 2));
            int sec = Int32.Parse(relative_to.Substring(17, 2));

            DateTime convertedDate = new DateTime(year, mounth, day, hour, min, sec);
            return convertedDate;
        }

        public FlightPlan GetFlightById(int id)
        {
            Console.WriteLine("GetFlightById need to be impliment");
            return null;
        }

        public void AddFlight(FlightPlan flight)
        {
            Console.WriteLine("AddFlight need to be impliment");
        }

        public void DeleteFlightById(int id)
        {
            Console.WriteLine("DeleteFlightById need to be impliment");
        }

        public List<ExternalServerModel> GetExternalServers()
        {
            return externalServerModels;
        }
    }
}