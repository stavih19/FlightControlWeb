using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers.Servers
{
    [Route("api/servers/{id}")]
    [ApiController]
    public class ServersDeleteController : ControllerBase
    {
        [HttpDelete]
        public void DeleteServer()
        {

        }
    }
}