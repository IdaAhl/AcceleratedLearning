using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetirementAge;
using RetirementAge.Domain;

namespace Pension.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAge_1978()
        {
            //var calculateAge = new UserPerson();
            //var yearsOld = calculateAge.YearsOld(new DateTime(1978,01,01));
            //Assert.AreEqual(40, yearsOld);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAge_future()
        {
            //var calculateAge = new UserPerson();
            //var yearsOld = calculateAge.YearsOld(new DateTime(2021, 01, 01));

        }

        [TestMethod]
        public void Test_findRetiretmentAge()
        {
            //var calculateAge = new UserPerson{BirthDate = new DateTime(1978,03,19), Country = "Malta", Gender = Gender.female};
            //var yearsOld = calculateAge.YearsOld(new DateTime(1978, 01, 01));
            //Assert.AreEqual(40, yearsOld);

        }
    }
}
