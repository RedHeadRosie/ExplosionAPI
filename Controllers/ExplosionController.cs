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
        public string Explosion(string input)
        {
            char[] charArr = input.ToCharArray();
            string newArray = "";

            foreach (char ch in charArr)
            {
                int charValue = int.Parse(ch.ToString());

                for (int i = 0; i < charValue; i++)
                {
                    newArray += ch;

                }
            }
            return newArray;
        }
    }
}
