using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Modul9
{
    //public delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {

            //WatchProgram();

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

        public static void AskAndRespond_ToUpper()
        {
            Console.Write("Enter a string to convert:");
            var stringFromUser = Console.ReadLine();
            Console.WriteLine(AddStars(stringFromUser));
        }

        public static string AddStars(string message)
        {
            return "*"+ message.ToUpper().Trim() + "*";
        }
    }
}
