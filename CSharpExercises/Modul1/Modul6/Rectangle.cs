using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6
{
    class Rectangle : Shape
    {
        double _height = 10;
        double _width = 20;
        

        public double Height
        {
            get{return _height;}
            set {_height = value; }

        }

        public override string ToString()
        {
            return $"I'm a rectangle with x= {X}, y= {Y}, height={_height} and width={_width}";
        }
    }
}
