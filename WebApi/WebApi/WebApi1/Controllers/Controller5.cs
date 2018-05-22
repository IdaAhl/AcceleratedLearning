using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("API5")]
    public class Controller5 : Controller
    {
        [Route("square"), HttpGet]
        public IActionResult Square(int? number)
        {
            if (number > 100)
                return BadRequest("Oj vilket stort tal");
            else
            {
                var result = number * number;
                return Ok(result);
            }
           
        }




        [Route("AddPersonAttribute"), HttpPost]
        public IActionResult AddPersonAttribute(SimpelPersonWithAttributes simpelPerson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok($"{simpelPerson.Name} som är {simpelPerson.Age} lades  till i databasen.");
        }

        [Route("AddPersonValidate"), HttpPost]
        public IActionResult AddPersonValidate(SimpelPerson simpelPerson)
        {
            var validateName = Regex.IsMatch(simpelPerson.Name, @"^[A-Za-zÅÄÖÅÄÖ]{2,20}$");

            if (validateName == false)
                return BadRequest("Fel namn");
            else if (Convert.ToInt32(simpelPerson.Age) > 120 || Convert.ToInt32(simpelPerson.Age) <= 0)
                return BadRequest("Åldern är fel");
            else
                return Ok($"{simpelPerson.Name} som är {simpelPerson.Age} lades  till i databasen.");
        }

        [Route("AddPerson"), HttpPost]
        public IActionResult AddPerson(SimpelPerson simpelPerson)
        {
            return Ok($"{simpelPerson.Name} som är {simpelPerson.Age} lades  till i databasen.");
        }

       


    }

    public class SimpelPersonWithAttributes
    {
        [Required]
        [RegularExpression("^[A-Za-zÅÄÖÅÄÖ]{2,20}$", ErrorMessage = "Något är fel på namnet")]
        //[StringLength(15, ErrorMessage = "Namnet får inte vara längre än {1} bokstäver.")]
        public string Name { get; set; }

        [Required]
        [Range(0, 120, ErrorMessage = "Åldern behöver vara mellan 1-120")]
        public int Age { get; set; }
    }


    public class SimpelPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
