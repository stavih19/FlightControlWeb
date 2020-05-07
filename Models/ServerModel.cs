using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class ServerModel
    {
        string serverURL;
        List<ExternalServerModel> externalServerModels;
        int port;
        string ipAdress;

        public ServerModel(string serverURL)
        {
            this.serverURL = serverURL; // another implement
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
    }
}
