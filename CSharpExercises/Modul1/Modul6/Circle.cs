using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6
{
    public class Circle
    {
        string _name = "Unknown";
        int _radius = 5;
        int _x = 5;
        int _y = 7;

        public Circle()
        {
        }
        public Circle(string name)
        {
            this._name = name;
        }

        public Circle(string name, int radius)
        {
            this._name = name;
            this._radius = radius;
        }

        public override string ToString()
        {
            return $"I'm a circle and x= {_x}, y= {_y} and radius={_radius}";
        }

        public double Area => ((_radius * _radius) * Math.PI);

        public void SayHello()
        {
            Console.WriteLine($"I'm a circle and my name is {_name}");

        }

        public void WriteArea()
        {
            Console.WriteLine($"My name is {_name}, I have a radius of {_radius} and an area of {(String.Format("{0:0.00}", Area))}");
        }

    }
}
