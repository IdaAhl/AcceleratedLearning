using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using RetirementAge.Domain;

namespace RetirementAge.Domain
{
    class App
    {
        public void Run(ICreatePerson cp)
        {
            var userPerson = cp.CreatePerson();

            int yersToRetirementForUserPerson = new CalculateYears().ToRetirement(userPerson);

            Console.WriteLine($"Du går i penson om {yersToRetirementForUserPerson} år");
        }
    }
}
