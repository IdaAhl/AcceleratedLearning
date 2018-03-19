using System;

namespace Modul3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hämta nummer


            var number = GetNumber();
            ChangeColor();
            //CheckNumber(number);
            //CheckNumberCon(number);
            //ReturnOneString(number);
            


        }

        public static int GetNumber()
        {
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine());
        }

        public static void ReturnOneString(int number)
        {
            var answer = (number>20) ? "Higher than 20" : (number==20)? "Equal to 20" : "Lover than 20";
            Console.WriteLine(answer);
           
        }

        public static void CheckNumberCon(int number)
        {
            bool isOver = false;
            if (number > 20)
                isOver = true;

            string answer = (isOver) ? "Higher than 20" : "Lower than 20";
            Console.WriteLine(answer);



        }
       

        public static void CheckNumber(int number)
        {
            if (number <= 20)
            {
                Console.WriteLine("Lower or equal to 20");
            }
            else
            {
                Console.WriteLine("Higher than 20");
            }
        }

        public static void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
