using System;

namespace Modul6
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);

            bob.SayHello();
            lisa.SayHello();
            Console.WriteLine();
            bob.WriteArea();
            lisa.WriteArea();

            Circle ali = new Circle("Ali");
            Circle johnDoe = new Circle();

            Console.WriteLine();
            ali.WriteArea();
            johnDoe.WriteArea();
        }
    }
}
