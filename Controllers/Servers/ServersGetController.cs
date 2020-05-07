using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightControlWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightControlWeb.Controllers.Servers
{
    [Route("api/servers")]
    [ApiController]
    public class ServersGetController : ControllerBase
    {
        [HttpGet]
        public ServerModel[] GetServers()
        {
            return null;
        }
        
        [HttpDelete]
        public void DeleteServer()
        {

        }
    }
}