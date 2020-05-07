using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class ServerModel
    {
        int server_id;
        string serverURL;
        List<ServerModel> externalServerModels;
        int port;
        string ipAdress;

        public void AddExternalServer(string newSrverURL)
        {
            int newID = externalServerModels.Count + 1;
            externalServerModels.Add(new ServerModel(newID, newSrverURL));
        }

        public void DeleteExternalServer(int id)
        {
            foreach (ServerModel temp in externalServerModels)
            {
                if (temp.server_id == id)
                {
                    externalServerModels.Remove(temp);
                    break;
                }
            }
        }

        public ServerModel(int server_id, string serverURL)
        {
            this.server_id = server_id;
            this.serverURL = serverURL;
        }

        public string ServerURL
        {
            get { return serverURL; }
            set { serverURL = value; }
        }

        public List<ServerModel> ExternalServerModels
        {
            get { return externalServerModels; }
            set { externalServerModels = value; }
        }
    }
}
