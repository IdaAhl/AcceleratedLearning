using System;

namespace Modul6
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Cube myCube = new Cube(2, 3, 4);
            Cube superCube = new Cube(50, 60, 70);

            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);

            Console.WriteLine(bob.ToString());

            Rectangle myRectangle = new Rectangle
            {
                X = 10,
                Y = 15
            };
            myRectangle.Height = 100;

            Console.WriteLine(myRectangle.ToString());

            /*
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
            */
        }
    }
}
