using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIrstBlazorApplication
{
    [Route("/[controller]")]
    [ApiController]
    public class Style : ControllerBase
    {
        private IConfiguration configuration { get; }

        public Style(IConfiguration config)
        {
            this.configuration = config;
        }
        [HttpGet]
        public async Task<ActionResult> ChangeStyle ([FromQuery] string style)
        {
            string TmcCodeValue = configuration.GetSection("TMCCode").Value;
            Response.Cookies.Append("TMCCode", TmcCodeValue);
            return Redirect("/");

        }
    }
}
