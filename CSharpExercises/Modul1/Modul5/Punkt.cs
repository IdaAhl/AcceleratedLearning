using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5
{
    public struct PunktStrukt
    {
        public int X;
        public int Y;

        public PunktStrukt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void ChangeFruit(string fruit)
        {

        }
        public void ChangeAge(int age)
        {

        }
        public void ChangeDate(DateTime date)
        {

        }

        public void ChangePunkt()
        {
            this.X = 500;
            this.Y = 500;

        }




    }
    class Punkt
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Punkt ()
        {

        }

        public Punkt(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
            
        public void Print()
        {
            Console.WriteLine(X);
        }

        public void MovePunkt500 ()
        {
            X += 500;
            Y += 500;
        }

        public void MoveX (int x)
        {
            X += x;
        }

    }
}
