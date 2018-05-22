using System;

namespace RetirementAge.Domain
{
    public class UserPerson
    {
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public Gender Gender { get; set; }
        public int YearsOld => (int)(DateTime.Now - BirthDate).Days / 365;
    }
}
