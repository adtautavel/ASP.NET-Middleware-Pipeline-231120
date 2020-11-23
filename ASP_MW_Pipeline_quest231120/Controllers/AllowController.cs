using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MW_Pipeline_quest231120.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllowController : ControllerBase
    {
        Allow allowObject = new Allow();


        [HttpGet]
        [Route("{parameter}")]
        public string GetAllow(string parameter)
        {
          
            return allowObject.PrintAllow(parameter);
        }

       
    }
}
