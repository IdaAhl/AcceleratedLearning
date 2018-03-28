using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Modul10
{
    class Program
    {
        static Dictionary<int, string> dictionary; 
        static void Main(string[] args)
        {
            dictionary = new Dictionary<int, string>();


            while (true)
            {
                Console.Write("Enter product id and name:");
                Console.ForegroundColor = ConsoleColor.Green;
                var fromUser = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (string.IsNullOrEmpty(fromUser))
                    break;

                int keyFromUser = 0;
                string valueFromUser = "";

                try
                {
                    var list = fromUser.Trim().Split(',');
                    valueFromUser = list[1].Trim();
                    keyFromUser = Int32.Parse(list[0]);
                    dictionary.Add(keyFromUser, valueFromUser);

                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"The productlist already contains id ");
                    ChangeValue(keyFromUser, valueFromUser);

                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid format");
                }
                catch (Exception)
                {
                    Console.WriteLine("Sometning wrong!");
                }
            }

            foreach (var product in dictionary)
            {
                Console.WriteLine($"Product id: {product.Key} and name: {product.Value}");
            }

       
        }

        private static void ChangeValue(int key, string value)
        {
            Console.WriteLine("Do you want to repalce value, Y or N");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                dictionary.Remove(key);
                dictionary.Add(key,value);
            }
           

        }
    }
}
