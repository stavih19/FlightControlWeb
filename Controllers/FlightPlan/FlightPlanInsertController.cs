using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers.FlightPlan
{
    [Route("api/FlightPlan")]
    [ApiController]
    public class FlightPlanInsertController : ControllerBase
    {
        [HttpPost]
        public void InsertFlightPlan() //maybe insert by parameter
        {

        }
    }
}