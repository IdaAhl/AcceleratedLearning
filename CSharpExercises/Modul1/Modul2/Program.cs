using System;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("How old are you? ");
            var age = Console.ReadLine();
            Console.Write("What is your favorite character? ");
            var letter = Console.ReadLine();

            Console.WriteLine(@"
Thank you!
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is: {0}", name);
            Age(age);
            LikeNumber(letter);
            Beep(name);
            Console.ForegroundColor = ConsoleColor.Gray;

            

        }

        public static void Age(String age)
        {
            int myAge;
            if (Int32.TryParse(age, out myAge))
            {
                Console.WriteLine("You have {0} years until retirement.", 65 - myAge);
            }
            else
                Console.WriteLine("Invalid age. ");
        }

        public static void LikeNumber(String letter)   
        {
            int j;
            if (Int32.TryParse(letter, out j))
            {
                Console.WriteLine("You like numbers");
            }
            else
                Console.WriteLine("You do not like numbers. ");
        }

        public static void Beep(String name)
        {
            if (name == "Ida")
                Console.Beep();

        }

         


        

    }
}
