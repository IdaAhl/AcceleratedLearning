using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RetirementAge.Infrastructure;

namespace RetirementAge.Domain
{
    class CreatePersonConsol : ICreatePerson
    {
        public UserPerson CreatePerson()
        {
            var userPerson = new UserPerson();
            userPerson.BirthDate = BirthDayQuestion();
            userPerson.Country = CountryQuestion();
            userPerson.Gender = GenderQuestion();
            return userPerson;
        }

        public String CountryQuestion()
        {
            while (true)
            {
                Console.WriteLine("I vilket land bor du?");
                var userInput = Console.ReadLine(); 
                try
                {
                    string country = TrySearchCountry(userInput);
                    Console.WriteLine($"Vi hämtar informationen för {country}");
                    return country;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{userInput} finns inte i vår information. Försök igen");
                }
            }
        }
    
        private string TrySearchCountry(string maybeCountry)
        {
            var retirementIoformation = new RetirementInformation().GetRetirementInformation();
            var country = retirementIoformation.First(c => c.CountryName.ToLower().Contains(maybeCountry.ToLower().Trim())).CountryName;
            return country;
        }

        public DateTime BirthDayQuestion()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("När är du född (ÅÅ-MM-DD)?");
                    var birthDay = DateTime.Parse(Console.ReadLine());
                    return birthDay;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel format försök igen");
                }
            }
        }

        public Gender GenderQuestion(String userInput)
        {
            //Console.WriteLine("Vilket kön har du?");
            //var userInput = Console.ReadLine();

            var genderFemaleList = new List<string> { "Q", "q","k", "K", "kvinna", "Kvinna" };
            var genderMaleList = new List<string> { "m", "M", "man", "Man" };

            if (genderFemaleList.Any(g => g == userInput || (g.Contains(userInput) && userInput.Length > 1)))
                return Gender.female;
            else if (genderMaleList.Any(g => g == userInput || (g.Contains(userInput)&& userInput.Length > 1)))
                return Gender.male;
            else
                return Gender.female;

        }
    }
}
