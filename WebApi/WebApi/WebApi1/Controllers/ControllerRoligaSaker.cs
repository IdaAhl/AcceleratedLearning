using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("fun")]
    public class ControllerRoligaSaker : Controller
    {

        [Route("egg"), HttpPost]
        public IActionResult Egg(string Namn)
        {
            if (Namn.ToLower() == "ägg")
            {
                return Ok($"Å nej, du borde inte äta {Namn} till frukost!");
            }
            else
            {
                return Ok($"Ja, {Namn} är gott!");
            }
        }


        [Route("color"), HttpPost]
        public IActionResult Color(string Name)
        {
            return Content($"<html><style>body {{background-color: {Name}; }}</style><body></body></html>", "text/html");
        }

        [Route("n"), HttpPost]
        public IActionResult Number(string number)
        {
            try
            {
                var intNumber = Convert.ToInt32(number);
                var squareNumber = intNumber * intNumber;
                return Ok($"{number} * {number } = {squareNumber}");
            }
            catch (Exception e)
            {
                return Ok($"Något gick fel");
            }
        }

        [Route("numbers"), HttpPost]
        public IActionResult Numbers(string from, string to)
        {
            try
            {
                StringBuilder textNumbers = new StringBuilder();
                var fromNumber = Convert.ToInt32(from);
                var toNumber = Convert.ToInt32(to);
                for (int i = fromNumber; i <= toNumber; i++)
                {
                    textNumbers.Append(Convert.ToString(i) + ",");
                }
                var text = textNumbers.ToString().TrimEnd(',');
                return Ok($"{text}");
            }
            catch (Exception e)
            {
                return Ok($"Något gick fel");
            }
        }




    }
}
