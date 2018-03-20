using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;

namespace Modul5
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //måste vara i en class
        //kan gör public för att synas på andra ställen

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hit enter");
            Console.ReadLine();

            //PunktStrukt minStrukt = new  PunktStrukt();

            
            PunktStrukt MinStrukt;  //behöver inte använda new, men då måste alla värden assignas innan den går att använda. 
            MinStrukt.X = 1;
            MinStrukt.Y = 10;

            Console.WriteLine($"Min punkt är {MinStrukt.X}");
            MinStrukt.ChangePunkt();
            Console.WriteLine($"Min punkt är {MinStrukt.X}");

            //log.Info("Hej!" + MinStrukt.X );


            //Punkt nyPunkt = new Punkt(10,4);

            //nyPunkt.Print();
            //nyPunkt.MovePunkt500();
            //nyPunkt.MoveX(50);
            //nyPunkt.Print();




            /*
            Point myPoint = new Point(3, 4);
            Console.WriteLine(myPoint.X);

            myPoint = ChangePoint(myPoint);
            Console.WriteLine(myPoint.X);

            StringBuilder message = new StringBuilder("sb: Lets go dancing!");
            Console.WriteLine(message);

            message = ChangeStringBuilder(message);
            Console.WriteLine(message);


            var repeatme = "Tennis anyone?";
            int[] testCycles = new int[] { 5, 50, 500, 5000 };
            var useStringbulider = false;


            List<TimeSpan> resultsList = new List<TimeSpan>();
            resultsList = TestString(testCycles, repeatme, resultsList, useStringbulider);

            Console.WriteLine("String test");
            PrintResults(resultsList);

            useStringbulider = true;
            List<TimeSpan> resultsListBuilder = new List<TimeSpan>();
            resultsListBuilder = TestString(testCycles, repeatme, resultsListBuilder, useStringbulider);

            Console.WriteLine("Stringbuilder test");
            PrintResults(resultsListBuilder);
            */


        }
        public static StringBuilder ChangeStringBuilder(StringBuilder message)
        {
            message.Append(" Yes that would be great");
            return message;
        }

        public static Point ChangePoint(Point point)
        {
            point.X = 500;
            point.Y = 900;

            return point;


        }

        public static void PrintResults (List<TimeSpan> resultsList)
        {
            foreach (var result in resultsList)
            {
                Console.WriteLine(result.TotalMilliseconds);
            }
        }


        public static List<TimeSpan> TestString(int[] testCycles, string repeatme, List<TimeSpan> resultsList, bool useStringbulider)
        { 
            for (int i = 0; i < testCycles.Length; i++)
            {
                var elapsedTime = ElapsedTime(repeatme, testCycles[i], useStringbulider);
                resultsList.Add(elapsedTime);
            }
            return resultsList;

        }

        public static TimeSpan ElapsedTime (string repeatme, int cycles, bool useStringbulider)
        {
            var generatedString = "";

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (!useStringbulider)
                generatedString = GenerateString(repeatme, cycles);
            else
                generatedString = GenerateStringWithStringBuilder(repeatme, cycles);

            stopWatch.Stop();
            return stopWatch.Elapsed;

        }

        public static string GenerateStringWithStringBuilder(string repeatme, int cycles)
        {
            var generadedWithStringBuilder = new StringBuilder("");
            for (int i = 0; i < cycles; i++)
            {
                generadedWithStringBuilder.Append(repeatme);
            }
            return generadedWithStringBuilder.ToString();
        }

        public static string GenerateString(string repeatme, int cycles)
        {
            var generatedString = "";
            for (int i = 0; i < cycles; i++)
            {
                generatedString += repeatme;
            }
            return generatedString;

        }
    }
}
