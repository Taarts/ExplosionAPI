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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Accum(string s)
        {
            var characters = s.ToCharArray();
            var exploded = new List<string>();
            for (var i = 0; i < characters.Length; i++)
            {
                var character = characters[i];
                var str = character.ToString();
                var letter = new List<string>();
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        letter.Add(str.ToUpper());
                    }
                    else
                    {
                        letter.Add(str.ToLower());
                    }
                }
                exploded.Add(string.Join("", letter));
            }
            return string.Join("-", exploded);
        }
    }
}
