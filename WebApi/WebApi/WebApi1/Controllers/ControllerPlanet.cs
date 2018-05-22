using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("planet")]
    public class ControllerPlanet : Controller
    {
        [Route("addPlanet2"), HttpPost]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok($"Lägg till planet {planet.Name}");
        }


        [Route("addPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }
            var planet = makePlanet(formContent);
            return Ok($"Ny planet {planet.Name}");
        }

        

        private Planet makePlanet(string formContent)
        {
            Planet planet = new Planet();
            var formContentTrim = formContent.Trim();
            string[] parts = formContentTrim.Split('&');
            foreach (var part in parts)
            {
                string[] splitPart = formContentTrim.Split('=');
                foreach (var split in splitPart)
                {
                    if (splitPart[0] == "planet")
                        planet.Name = splitPart[1];
                    else if (splitPart[0] == "storlek")
                        planet.Size = Convert.ToInt32(splitPart[1]);
                }
            }
            return (planet);
        }
    }

    public class Planet
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }
}
