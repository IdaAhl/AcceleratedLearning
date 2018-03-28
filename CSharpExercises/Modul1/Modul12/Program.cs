using System;
using System.Collections.Generic;

namespace Modul12
{
    class Program
    {
        static void Main(string[] args)
        {

            const int factor = 5;
            Func<int, int, int> multipler = (n,a) => n * factor;

            var result = multipler(5,5);



            string[] rockStarArray = { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };
            List<string> rockStarsList = new List<string> { "Jim", "Ozzy", "David", "Freddie","Jan","Lars" };

            //DisplayArrayOfRockStars(rockStarArray);
            //Console.WriteLine();
            //DisplayListOfRockStars(rockStarsList);
            Console.WriteLine();
            //DisplayRockStars(rockStarArray);
            Console.WriteLine();
            //DisplayRockStars(rockStarsList);

            var stars = rockStarsList.FindAll(name => name.Length > 5);
            foreach (var star in stars)
            {
                Console.WriteLine(star);
            }
        }

        public static void DisplayArrayOfRockStars(string[] rockstars)
        {
            Console.WriteLine("My rockstars (Array):");
            foreach (var star in rockstars)
            {
                Console.WriteLine(star);
            }
        }

        public static void DisplayListOfRockStars(List<string> rockstars)
        {
            rockstars.Add("Amy Winehouse");
            Console.WriteLine("My rockstars (List):");
            foreach (var star in rockstars)
            {
                Console.WriteLine(star);
            }
        }

        public static void DisplayRockStars(IEnumerable<string> rockstars)
        {
            Console.WriteLine("My rockstars (IEnumerable):");
            foreach (var star in rockstars)
            {
                Console.WriteLine(star);
            }
        }




    }
}
