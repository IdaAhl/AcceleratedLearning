using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("CRM")]
    public class ControllerCRM : Controller
    {
        [Route("CheckCustomer"), HttpPost]
        public IActionResult CheckCustomer(string person)
        {
            var customer = person.ToLower().Trim();
            if (customer == "stewie")
                throw new Exception("Data error!!");
            else if (customer == "peter")
            {
                var link = "http://www.quirkyscience.com/wp-content/uploads/2012/06/Explosion-Image-by-US-Department-of-Defense.jpg";
                return Content($"<img src=\"{link}\">", "text/html");

            }

            else
            {
                return Ok($"{person}");

            }
            


        }

        [Route("CheckOrderNumber"), HttpPost]
        public IActionResult CheckOrderNumber(string orderNumber)
        {

            if (!Regex.IsMatch(orderNumber, @"^[A-Z]{2}[-][0-9]{4}$"))
                return BadRequest("Nu får du försöka igen");


            string[] parts = orderNumber.Split('-');
            if (Convert.ToInt32(parts[1]) > 3000)
                return NotFound("För högt värde");
            else
                return Ok($"Order {orderNumber} hittades i databasen");
        }


        [Route("ShareChocolate"), HttpPost]
        public IActionResult ShareChocolate(string persons)
        {
            try
            {
                var intPersons = Convert.ToInt32(persons);
                if (intPersons <= 0)
                    return BadRequest($"Har alla gått hem?");
                else
                    return Ok($"{25 / intPersons} bitar var");
            }
            catch (Exception e)
            {
                return Ok($"Något gick fel");
            }
        }
    }
}
