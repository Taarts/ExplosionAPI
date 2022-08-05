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
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string s)
        {
            var characters = s.ToCharArray();
            var exploded = new List<string>();
            foreach (var character in characters)
            {
                var str = character.ToString();
                var count = int.Parse(str);
                for (var i = 0; i < count; i++)
                {
                    exploded.Add(str);
                }
            }
            return string.Join("", exploded);
        }
    }
}
