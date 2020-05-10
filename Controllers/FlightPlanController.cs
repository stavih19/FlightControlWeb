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
    public class FlightPlanController : ControllerBase
    {
        ServerModel serverM = ServerModel.Instance;

        /*// GET: api/FlightPlan
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/FlightPlan/5
        [HttpGet("{id}", Name = "GetFlightPlan")]
        public string Get(int id)
        {
            FlightPlanItem flight = serverM.GetFlightById(id);
            string response = JsonConvert.SerializeObject(flight);
            return response;
        }

        // POST: api/FlightPlan
        [HttpPost]
        public void Post(JsonElement flightJson)
        {
            FlightPlanItem flight = JsonConvert.DeserializeObject<FlightPlanItem>(flightJson.ToString());
            serverM.AddFlight(flight);
        }

        /*// PUT: api/FlightPlan/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        /*// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
