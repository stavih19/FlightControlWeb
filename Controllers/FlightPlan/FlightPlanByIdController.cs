using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers.FlightPlan
{
    [Route("api/FlightPlan/{id}")]
    [ApiController]
    public class FlightPlanByIdController : ControllerBase
    {
        [HttpGet]
        public FlightPlanItem GetFlightPlan()
        {
            return null;
        }
    }
}