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
    public class ReversedController : ControllerBase
    {
        [HttpGet]
        public string Backwards(string str = "123678")
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
    }
}
