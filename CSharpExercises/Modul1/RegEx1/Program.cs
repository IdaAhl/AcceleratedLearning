using System;
using System.Text.RegularExpressions;

namespace RegEx1
{
    class Program
    {
        void త్()
        {
            Console.WriteLine("త్");
        }
        static void Main(string[] args)
        {

            PrintPartOfProductNumber();
            /*
            Console.Write("Skriv något kul");
            var input = Console.ReadLine();
            var isValid = ValidatePhoneNo(input);

            if (isValid)
                Console.WriteLine("fin fint");
            else
            {
                Console.WriteLine("Bu!!");
            }
            */


        }

        public static bool ValidatePhoneNo(string input)
        {
            return Regex.IsMatch(input, @"^\d{2,10}-?\d{1,8}$");
        }

        public static bool ValidateEmail(string input)
        {
            return Regex.IsMatch(input, @"^\w+(\.\w+)*@\w+(\.\w+)*\.\w{2,10}$");
        }

        public static bool ValidateWord(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-ZåäöÅÄÖ]+$");
        }

        public static bool ProductNumberIsValidt(string input)
        {
            return Regex.IsMatch(input, @"^[A-ZÅÄÖ]{2}(-\d{3}){2}$");
        }

        public static void PrintPartOfProductNumber()
        {
            var text = "EF-567-789";
            var match = Regex.Match(text, @"(?<lager>\w\w)-(?<hylla>\d\d\d)-(?<plats>\d\d\d)");
            Console.WriteLine(match.Groups.Count);
            Console.WriteLine(match.Groups["lager"]);
            Console.WriteLine(match.Groups["hylla"]);
            Console.WriteLine(match.Groups["plats"]);
            

            string textText = "One    car red car blue car";
            Console.WriteLine(Regex.Match(textText, @"(\w+)\s+(car)"));
            

            var textReplace = Regex.Replace(textText, "One", "1");
            Console.WriteLine(textReplace);
            Console.WriteLine(textText);


        }




    }
}
