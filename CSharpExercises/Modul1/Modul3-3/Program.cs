using System;

namespace Modul3_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = (Console.ReadLine());
            Console.Write("Rows: ");
            var rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Colums: ");
            var colums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Repeat name: ");
            var repeat = Convert.ToInt32(Console.ReadLine());

            var newName = RepeatName(name, repeat);
            WriteMatrix(newName, rows, colums);

        }
        public static void WriteMatrix(string name, int rows, int colums)
        {
            for (var i = 0; i < rows; i++)
            {
                var names = "";
                for (var j = 0; j < colums; ++j)
                {
                    names += name + " ";
                }
                Console.WriteLine(names);
            }
        }

        public static string RepeatName(string name, int repeat)
        {
            var repeatName = "";
            for (var i = 0; i < repeat; i++)
            {
                repeatName += name;
            }
            return repeatName;
        }

        public static string ReverseName(string name)
        {
            char[] endName = name.ToCharArray();
            Array.Reverse(endName);
            
            var newName = name + String.Join("", endName) ;
            return newName;
        }

        public static int Test (int testnumber)
        {
            return testnumber;
        }
    }
}
