using System;

namespace Modul1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            tryString();
        }

        public static void tryString ()
        {
            var name = "Ida 5";
            name = name + 5;
            Console.WriteLine(name);
        }
    }
}
