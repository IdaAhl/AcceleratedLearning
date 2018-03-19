using System;
using System.Collections.Generic;
using System.Text;

namespace Modul2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many fruits do you want to add?");

            var numberFruits = Convert.ToInt32(Console.ReadLine());
            var fruits = new List<String>();

            for (var i = 1; i <= numberFruits; i++ )
            {
                Console.Write("Enter fruit {0}: ", i);
                var fruit = Console.ReadLine();
                fruits.Add(fruit);

            }

            var builder = new StringBuilder();

            foreach (var fruit in fruits)
            {
                builder.Append(fruit);
            }

            Console.WriteLine(builder);

            Console.Write("Enter fruit 1: ");
            var fruitOne = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            var fruitTwo = Console.ReadLine();
            Console.Write("Enter fruit 3: ");
            var fruitThree = Console.ReadLine();
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;

         
            //var placeholdersFruits = String.Format("You entered three fruits: {0}, {1}, {2}", fruitOne, fruitTwo, fruitThree);

            Console.WriteLine("You entered three fruits:" + fruitOne + ", "+ fruitTwo + ", " + fruitThree);
            Console.WriteLine("You entered three fruits: {0}, {1}, {2}", fruitOne, fruitTwo, fruitThree);
            Console.WriteLine($"You entered three fruits: {fruitOne}, {fruitTwo}, {fruitThree}");


            Console.ForegroundColor = ConsoleColor.Gray;



            
        }
    }
}
