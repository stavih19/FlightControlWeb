using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb
{
    public class ExternalServerModel
    {
        int server_id;
        string serverURL;

        public ExternalServerModel(int server_id, string serverURL)
        {
            this.server_id = server_id;
            this.serverURL = serverURL;
        }

        public int Server_id
        {
            get { return server_id; }
        }

        public string ServerURL
        {
            get { return serverURL; }
            set { serverURL = value; }
        }
    }
}
