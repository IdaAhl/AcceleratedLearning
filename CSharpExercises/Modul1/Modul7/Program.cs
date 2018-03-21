using System;

namespace Modul7
{
    class Program
    {
        static void Main(string[] args)
        {
            var elevator1 = new Elevator(10, 20, 5, "Ida", 10 );
            //elevator1.Installation();

            for (int i = 0; i < 15; i++)
            {
                elevator1.GoUp();
            }

            Console.WriteLine($"Nu är du på {elevator1.CurrentFloor} våningen och hissen har åkt {elevator1.UsedTime}");
        }
    }
}
