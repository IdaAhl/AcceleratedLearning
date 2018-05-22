using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/ex1")]
    public class Ex1Controller : Controller
    {

        [Route("hello")]
        public string Hello()
        {
            var randomNumber = RandomNumber(1, 3);
            var helloString = getHelloString(randomNumber);
            return helloString;
        }

        [Route("helloWorld")]
        public IActionResult HelloWorld()
        {
            DateTime dt = new DateTime();
            return Ok("HelloWorld");
        }

        public string getHelloString(int randomNumber)
        {
            var helloString = "";
            switch (randomNumber)
            {
                case 1:
                    helloString = "Hello world";
                    break;
                case 2:
                    helloString = "Bonjour le monde";
                    break;
                case 3:
                    helloString = "Hei maailma";
                    break;
            }
            return helloString;
        }

        public int RandomNumber(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to+1);
        }

    }
}
