using System;
using System.Collections.Generic;
using System.Text;
using RetirementAge.Domain;

namespace RetirementAge.Infrastructure
{
    class RetirementInformation
    {
        public List<RetirementCountryInformation> GetRetirementInformation()
        {
            List<RetirementCountryInformation> list = new List<RetirementCountryInformation>();
            var retirementSwedenK = new RetirementCountryInformation { Gender = Gender.female, CountryName = "Sverige", RetirementAge = 67 };
            list.Add(retirementSwedenK);
            var retirementSwedenM = new RetirementCountryInformation { Gender = Gender.male, CountryName = "Sverige", RetirementAge = 65 };
            list.Add(retirementSwedenM);

            var retirementFranceK = new RetirementCountryInformation { Gender = Gender.female, CountryName = "Frankrike", RetirementAge = 65 };
            list.Add(retirementFranceK);
            var retirementFranceM = new RetirementCountryInformation { Gender = Gender.male, CountryName = "Frankrike", RetirementAge = 65 };
            list.Add(retirementFranceM);

            var r3K = new RetirementCountryInformation { Gender = Gender.female, CountryName = "Malta", RetirementAge = 62 };
            list.Add(r3K);
            var r3M = new RetirementCountryInformation { Gender = Gender.male, CountryName = "Malta", RetirementAge = 62 };
            list.Add(r3M);

            return list;
        }
    }
}
