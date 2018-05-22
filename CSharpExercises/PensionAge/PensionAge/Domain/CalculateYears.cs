using System;
using System.Collections.Generic;
using System.Text;
using RetirementAge.Domain;
using RetirementAge.Infrastructure;

namespace RetirementAge.Domain
{
    public class CalculateYears
    {
        public int ToRetirement(UserPerson userPerson)
        {
            var retirementInformation = new RetirementInformation().GetRetirementInformation();
            var retirementAgeForUser = new FindRetirementAge().FindAgeForUser(retirementInformation, userPerson);
            var yearsToRetirement = retirementAgeForUser - userPerson.YearsOld;

            return yearsToRetirement;
        }

    }
}
