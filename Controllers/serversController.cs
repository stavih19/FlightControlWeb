using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Newtonsoft.Json;
using FlightControlWeb.Models;

namespace FlightControlWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class serversController : ControllerBase
    {
        ServerModel serverM = ServerModel.Instance;

        // GET: api/servers
        [HttpGet]
        public string Get()
        {
            List<ExternalServerModel> servers = serverM.GetExternalServers();
            string response = "";
            foreach (ExternalServerModel external in servers)
            {
                response += JsonConvert.SerializeObject(external);
            }
            return response;
        }

        /*// GET: api/servers/5
        [HttpGet("{id}", Name = "GetServers")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/servers
        [HttpPost]
        public void Post(JsonElement externalServer)
        {
            ExternalServerModel external = JsonConvert.DeserializeObject<ExternalServerModel>(externalServer.ToString());
            serverM.AddExternalServer(external.ServerURL);
        }

        /*// PUT: api/servers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            serverM.DeleteExternalServer(id);
        }
    }
}
