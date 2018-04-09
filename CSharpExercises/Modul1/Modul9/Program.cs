using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Modul9
{


    class Program
    {
        static event Action<int> spacePressed;
        static void Main(string[] args)
        {
            spacePressed += WriteLine;
            spacePressed += WriteLine;
            ListenToKeyPress();

            //WatchProgram();
            //AskUserAndRespond(ToUpper);
            //AskUserForNumberAndRespond(MinusTio);
            //AskUserForNumberAndRespond(PlusTio);
            //AskUserForSomethinFunAndRespond(WriteSomethingFun);

        }

        private static void WriteLine(int something)
        {
            Console.WriteLine(something);
        }

        private static void ListenToKeyPress()
        {
            char keyPressed;
            do
            {
                keyPressed = Console.ReadKey(true).KeyChar;
                if (keyPressed == ' ')
                {
                    spacePressed.Invoke(5);
                }
            }
            while (keyPressed != 'q');
        }

        private static  void AskUserAndRespond(Func<string, string> converter)
        {
            Console.Write($"Enter a string to convert:");
            string input = Console.ReadLine().Trim();
            string answer = converter(input);
            Console.WriteLine($"Here is the result:{answer}\n");
        }

        private static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        private static string Tripple(string s)
        {
            return s + s + s;
        }

        private static void AskUserForNumberAndRespond(Func<int, int> newNumber)
        {
            Console.Write($"Enter a number to convert:");
            var input = int.Parse(Console.ReadLine());
            var answer = newNumber(input);
            Console.WriteLine($"Here is the result:{answer}\n");
        }

        private static int PlusTio(int number)
        {
            return number + 10;
        }

        private static int MinusTio(int number)
        {
            return number - 10;
        }

        private static void AskUserForSomethinFunAndRespond(Action<string> somethingFun)
        {
            Console.Write($"Enter somethingfun:");
            var input = Console.ReadLine();
            somethingFun(input);
        }

        private static void WriteSomethingFun(string somethingFun)
        {
            Console.WriteLine($"{somethingFun} is fun");
        }

        public static void WatchProgram()
        {
            FileSystemWatcher look = new FileSystemWatcher();
            look.Path = "c:\\TMP";
            look.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            look.Filter = "*.txt";
            look.Changed += new FileSystemEventHandler(OnChanged);
            look.Renamed += new RenamedEventHandler(OnRenamed);
            look.EnableRaisingEvents = true;

            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'q')
                    break;
            }
        }
        static void OnChanged(object source, FileSystemEventArgs a)
        {
            Console.WriteLine("Ändrar");
        }
        static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        
    }
}
