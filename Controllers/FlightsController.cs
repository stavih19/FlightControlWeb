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
    public class FlightsController : ControllerBase
    {
        ServerModel serverM = ServerModel.Instance;

        // GET: api/Flights/date
        [HttpGet]
        public string Get(string relative_to)
        {
            string requestString = Request.QueryString.Value;
            bool isExternals = requestString.Contains("sync_all");
            FlightPlanItem[] flights = serverM.GetFlights(relative_to, isExternals);
            string response = "";
            foreach (FlightPlanItem flight in flights)
            {
                response += JsonConvert.SerializeObject(flight);
            }
            return response;
        }

        /*// GET: api/Flights/5
        [HttpGet("{id}", Name = "GetFlights")]
        public string Get(int id)
        {
            FlightPlanItem flight = serverM.GetFlightById(id);
            string response = JsonConvert.SerializeObject(flight);
            return response;
        }*/

        /*// POST: api/Flights
        [HttpPost]
        public void Post(JsonElement flightJson)
        {
            FlightPlanItem flight = JsonConvert.DeserializeObject<FlightPlanItem>(flightJson.ToString());
            serverM.AddFlight(flight);
        }*/

        /*// PUT: api/Flights/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            return;
        }*/

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            serverM.DeleteFlightById(id);
        }
    }
}
