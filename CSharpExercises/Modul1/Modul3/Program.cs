using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When did you go to bed yesterday? ");
            var bedTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("when did you wake up? ");
            var wakeupTime = Convert.ToInt32(Console.ReadLine());

            var sleepingTime = (24 - bedTime) + wakeupTime;

            if (sleepingTime <= 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You have only slept {sleepingTime} hours. Go back to bed!");
            }
            else if (sleepingTime >= 11)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You have slept {sleepingTime} hours. That's a lot.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have slept well.");
            }
                
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("When did you go to bed yesterday (e.g 2017-08-09 22:30)?");
            var bedTimeTwo = DateTime.Parse(Console.ReadLine());
            Console.Write("when did you wake up (e.g 2017-08-09 22:30)? ");
            var wakeupTimeTwo = DateTime.Parse(Console.ReadLine());

            var sleepingTimeTwo = wakeupTimeTwo - bedTimeTwo;

            Console.WriteLine(sleepingTimeTwo);

        }
    }
}
