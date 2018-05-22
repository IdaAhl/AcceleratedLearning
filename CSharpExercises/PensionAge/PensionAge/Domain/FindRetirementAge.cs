using System;
using System.Collections.Generic;
using System.Text;
using RetirementAge.Domain;

namespace RetirementAge.Domain
{
    public class FindRetirementAge
    {
        public int FindAgeForUser(List<RetirementCountryInformation> countryAgeList, UserPerson userPerson)
        {
            var retirementAge = 0;
            foreach (var country in countryAgeList)
            {
                if (userPerson.Country == country.CountryName && userPerson.Gender == country.Gender)
                    retirementAge = country.RetirementAge;
            }
            return retirementAge;
        }
    }
}
