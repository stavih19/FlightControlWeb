using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public sealed class ServerModel
    {
        private static readonly ServerModel instance = new ServerModel();

        static ServerModel() { }

        private ServerModel()
        {
            //run the server
        }

        public static ServerModel Instance
        {
            get { return instance; }
        }

        string serverURL = "127.0.0.1";
        List<ExternalServerModel> externalServerModels;
        int port;
        string ipAdress;

        public string ServerURL
        {
            get { return serverURL; }
            set { serverURL = value; }
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

        public FlightPlanItem[] GetFlights(string relative_to, bool isExternals)
        {
            Console.WriteLine("GetFlights need to be impliment");
            return null;
        }

        public FlightPlanItem GetFlightById(int id)
        {
            Console.WriteLine("GetFlightById need to be impliment");
            return null;
        }

        public void AddFlight(FlightPlanItem flight)
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