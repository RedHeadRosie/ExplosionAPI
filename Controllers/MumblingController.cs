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
        public string Mumbling(string input)
        {
            //turn the string into an array so we can look at each letter.
            char[] charArr = input.ToCharArray();
            //initialise and new string to add to and to return.
            string newArray = "";
            int counter = 0;
            string dash = "";

            foreach (char ch in charArr)
            {
                newArray += dash;
                //add the uppercase version of each item of the array of characters to the string we want to return
                newArray += char.ToUpper(ch);

                int internalCounter = 1;
                while (internalCounter <= counter)
                {
                    newArray += char.ToLower(ch);
                    internalCounter++;
                }
                dash = "-";
                counter++;
            }
            return newArray;
        }
    }
}
