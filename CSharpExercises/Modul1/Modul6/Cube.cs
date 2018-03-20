using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Modul6
{
    class Cube
    {

        string _name = "Cubis";
        double _height;
        double _width;
        double _depth;

        public Cube(double height, double width, double depth)
        {
            this._height = height;
            this._width = width;
            this._depth = depth;
        }

        public double Volume => _height * _width * _depth;

        //public double Area => _height * _width;

        public void WriteVolume()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The volyme of the cube is {Volume}");
        }



    }
    
        
}
