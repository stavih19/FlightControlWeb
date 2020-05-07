using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers
{
    [Route("api/Flights?relative_to<{date_time}>")]
    [ApiController]
    public class FlightsInternalController : ControllerBase
    {
        [HttpGet]
        public FlightPlanItem[] GetFlightPlan()
        {
            // make html file?
            return null;
        }
    }
}