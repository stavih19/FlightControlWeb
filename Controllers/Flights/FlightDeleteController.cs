using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers.Flights
{
    [Route("api/Flights/{id}")]
    [ApiController]
    public class FlightDeleteController : ControllerBase
    {
        [HttpDelete]
        public void DeleteFlightPlan()
        {

        }
    }
}