using System;

namespace Modul3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = (Console.ReadLine());
            Console.Write("Times to repeat: ");
            var times = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter one more number: ");
            //var colums = Convert.ToInt32(Console.ReadLine());



            WriteFour(name, times);

        }

        public static void checkTimes(string times)
        {

        }

        public static void WriteOne(string name, int times)
        {
            var i = 0;
            while (i < times)
            {
                Console.WriteLine($"Your name is {name}");
                i++;
            }

        }

        public static void WriteTwo(string name, int times)
        {
            var i = 0;
            while (true)
            {
                Console.WriteLine(String.Format("Your name is {0}", name));
                i++;
                
                if (i == times)
                    break;
            }

        }

        public static void WriteThree (string name, int times)
        {
            var i = 0;
            do
            {
                Console.WriteLine("Your name is " + name);
                i++;

            } while (i < times);
        }

        public static void WriteFour(string name, int times)
        {
            for (var i = 0; i< times; i ++)
            {
                Console.WriteLine("Your name is " + name);
                i++;
            }

        }

        public static void WriteFive(string name, int times)
        {
            for (var i = 0; i < times; i++)
            {
                //for (var j = 0, )
                Console.WriteLine("Your name is " + name);
                i++;
            }

        }


    }
}
