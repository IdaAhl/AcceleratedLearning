using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7
{
    class Elevator
    {
        public string Name { get; private set; }
        public int HighestFloor { get; private set; }
        public int LowestFloor { get; private set; }
        public int CurrentFloor { get; private set; }
        public int UsedTime { get; private set; }

        public Elevator(string name)
        {
            Name = name;
        }

        public Elevator(int highestFloor, int lowestFloor, int currentFloor, string name, int usedTime) :this(name)
        {
            HighestFloor = highestFloor;
            LowestFloor = lowestFloor;
            CurrentFloor = currentFloor;
            UsedTime = usedTime;
        }

        public void GoUp()
        {
            if (NeedService())
            {
                Console.WriteLine("Hissen behöver service, ta trapporna istället");
                ServiceElevator();
            }
            else if (CurrentFloor < HighestFloor)
            {
                CurrentFloor++;
                UsedTime++;
                Console.WriteLine($"Välkommen till våning {CurrentFloor}");
            }
            else
            {
                Console.WriteLine($"Du är på högsta våningen nu får du ta portalen till {LowestFloor} våning, Swoch!!");
                CurrentFloor = LowestFloor;
                UsedTime++;
            }
        }
        public bool NeedService()
        {
            if (UsedTime >= 12)
            {
                return true;
            }
            return false;
        }

        public void ServiceElevator()
        {
            UsedTime = 0;
            Console.WriteLine("Nu är hissen klar att användas.");
        }

        public void Installation()
        {
            HighestFloor = 10;
            LowestFloor = 0;
            CurrentFloor = 0;
            UsedTime = 0;
            Console.WriteLine("Hissen är klar att andvändas");
        }
    }
}
