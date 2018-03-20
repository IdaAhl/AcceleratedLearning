using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6
{
    class Rectangle
    {
        double _height = 10;
        double _width = 20;
        int _x = 35;
        int _y = 40;

        

        public double Height
        {
            get{return _height;}
            set {_height = value; }

        }

        public override string ToString()
        {
            return $"I'm a rectangle with x= {_x}, y= {_y}, height={_height} and width={_width}";
        }
    }
}
