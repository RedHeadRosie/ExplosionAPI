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
        public string ReverseString(string input)
        {
            var resultstring = new string(input.ToCharArray().Reverse().ToArray());
            //Console.WriteLine(resultstring);
            return resultstring;
        }
    }
}
