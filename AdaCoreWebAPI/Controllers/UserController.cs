using AdaCoreWebAPI.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaCoreWebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public bool Login([FromBody] User user)
        {
            return true;
        }

        [HttpPost]
        [Route("add")]
        public void Add([FromBody] User user)
        {
            
        }
            
    }
}
