using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string RevString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
