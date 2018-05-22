using System;
using RetirementAge;
using RetirementAge.Domain;

namespace RetirementAge
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Run(new CreatePersonConsol());
        }
    }
}
