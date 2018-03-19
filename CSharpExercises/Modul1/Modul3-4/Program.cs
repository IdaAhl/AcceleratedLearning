using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = GetNumber();
            //ChangeColor();
            //CheckNumber(number);
            
            var names = GetNames();

            //var surname = GetSurname();
            //PrintNames(names, surname);
            //var allowNames = AllowNames(names);
  
            var approvedNames = GetApprovedNames(names);
            // PrintApprovedNames(approvedNames);
            PrintIntersectNames(names, approvedNames);
            //PrintNamesWithBreak(names, surname, allowNames);

        }
        public static int GetNumber()
        {
            Console.Write("Enter a number: ");
            return int.Parse(Console.ReadLine());
           
        }

        public static void CheckNumber(int number)
        {
            if (number <=20)
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

        public static List<string> GetNames()
        {
            Console.Write("Enter names: ");
            var input = Console.ReadLine() ?? ""; //är den null blir den ""
            List<string> names = input.Split(',').ToList();

            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].Trim();
            }
            return names;
        }

        public static string GetSurname()
        {
            Console.Write("Enter surname: ");
            return (Console.ReadLine());
        }

        public static bool AllowNames(List<String> names)
        {
            foreach (var name in names)
            {
                var tempname = name.Trim().ToLower();
                if (tempname.Contains("allow"));
                return true;
            }
            return false;
        }


        public static List<string> GetApprovedNames(List<String> names)
        {
            var approvedNames = new List<string>();

            foreach (var name in names)
            {
                var tempname = name.Trim().ToLower();
                if (tempname.Contains("allow"))
                {
                    tempname = name.Remove(0, 5);
                    approvedNames.Add(tempname);
                }     
            }
            return approvedNames;

        }

        public static void PrintApprovedNames(List<string> approvedNames)
        {
            foreach (var name in approvedNames)
            {
                Console.WriteLine(name);
            }
        }


        // "Oliver,Anders,Peter,Karin"    "Peter,Karin"
        // ==> "Peter,Karin"

        public static void PrintIntersectNames(List<string> names, List<string> approvedNames)
        {

            var x = names.Intersect(approvedNames);
            foreach (var name in x)
                Console.WriteLine(name);


            /*
            foreach (var name in names)
            {
                var tempName = name;
                foreach (var approvedName in approvedNames)
                {
                    if(tempName == approvedName)
                        Console.WriteLine(approvedName);

                }
            }
            */

        }
        


        public static void PrintNamesWithBreak(List<String> names, string surname, bool allowZelda)
        {
            foreach (var name in names)
            {
                if (name == "Zelda" && allowZelda == true)
                {
                    Console.WriteLine($"Zelda {surname}");
                }
                else if (name.ToLower().Contains("allow")) continue;
                else if (name == "Zelda")  break;
                else
                {
                    Console.WriteLine($"{name} {surname}");
                }
            }
        }

        public static void PrintNames(List<String> names, string surname)
        {
            foreach (var name in names)
            {
                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"{name} {surname}");
                }
                else
                {
                    Console.WriteLine("XXX Andersson");
                }
                
            }
        }

    }
}
