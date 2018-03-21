using System;
using System.IO;
using System.Transactions;

namespace Modul8
{
    class Chocolate
    {
        public int Pieces { get; set; }

        public decimal Share(int persons)
        {  
            return Pieces / (decimal)persons;
        }
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a file name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                var file = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                try
                {
                    File.Create(file);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Hurra din fil är skapad");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're not authorized to create this file");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Could not find a part of the path");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Illegal characters in path");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something wrong");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            

            

            //File.Create(@"c:\bird.txt");


            /*
            var chocolate = new Chocolate(){Pieces = 24};
            Console.WriteLine($"The chocolate contains {chocolate.Pieces} ");
            Console.Write("How many do you want to share? ");

            var persons = int.Parse(Console.ReadLine());

             try
             {
                 //var noll = 0;
                 //var number = 24 / noll;
                 var result = chocolate.Share(persons);
                 Console.WriteLine($"Everyone gets {result}");
             }
             catch (DivideByZeroException )
             {
                 Console.WriteLine("Zero people can't divide a chocolate");
             }
             */


        }
    }
}
