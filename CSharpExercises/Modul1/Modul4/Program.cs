using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = AskUserForSeparator();
            bool wantErrorMessage = AskUserForErrorMessage();

            // Hämta string
            string input = GetInputFromUser(wantErrorMessage);
            string[] namesArray = CreateArrayOfPeople(input, separator);

            // se om namen är tillräckligt långa
            //input = ToShortNames(input);
            // se om namen är tillräckligt långa
            // gör om till array 

            //namesArray = CleanArray(namesArray);

            //skriv ut med super framför 
            PrintNamesArray(namesArray);

            //var names = GetNames();
            //names = UpperNames(names);
            //names = SuperNames(names);
            //names = AddStars(names);
            //PrintNames(names);

            //WithoutMethods();

        }

        private static char AskUserForSeparator()
        {
            var inputFromUser = "";
            char separator = 'A';

            while (true)
            {
                Console.Write("Which separator do you vant to use (default is ,)? ");
                inputFromUser = Console.ReadLine() ?? ""; //är den null blir den ""

                if (ifEmpty(inputFromUser))
                {
                    separator = ',';
                    break;
                }
                else if (inputFromUser.Length > 1)
                    continue;
                else
                {
                    separator = Convert.ToChar(inputFromUser);
                    break;
                }
            }
            return separator;
        }

        private static bool AskUserForErrorMessage()
        {
            var inputFromUser = "";
            var wantErrorMessage = true;

            while (true)
            {
                Console.Write("Do you want to see error messages (default is yes)? ");
                inputFromUser = Console.ReadLine() ?? ""; //är den null blir den ""

                inputFromUser = inputFromUser.Trim().ToLower();

                if (inputFromUser == "no")
                {
                    wantErrorMessage = false;
                    break;
                }
                break;
            }
            return wantErrorMessage;
        }

        private static string GetInputFromUser(bool wantErrorMessage)
        {
            var inputFromUser = "";
            while (true)
            {
                Console.Write("Enter names: ");
                inputFromUser = Console.ReadLine() ?? ""; //är den null blir den ""

                if (ifEmpty(inputFromUser))
                {
                    PrintErrorMessageOnConsole(wantErrorMessage);
                    //Console.WriteLine("Empty, do again!");
                    continue;
                }
                else if(NamesToShortOrLong(inputFromUser))
                {
                    PrintErrorMessageOnConsole(wantErrorMessage);
                    //Console.WriteLine("A name can only have 2 - 9 letters");
                    continue;
                }
                break;
            }
            return inputFromUser;
            
        }

        private static bool ifEmpty(String names)
        {
            if (string.IsNullOrWhiteSpace(names))
            {
                return true;
            }
            else
                return false;

        }

        private static bool NamesToShortOrLong(String names)
        {
            var array = names.Split(',');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim();

                if (array[i].Length < 3)
                //if (array[i] == "Ida")
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private static void PrintErrorMessageOnConsole(bool wantErrorMessage)
        {
            if (wantErrorMessage)
                Console.WriteLine("Something is wrong, try again");
        }










        private static string[] CleanArray(string[] namesArray)
        {
            for (int i = 0; i < namesArray.Length; i++)
            {
                namesArray[i] = namesArray[i].Trim();
                namesArray[i] = namesArray[i].Replace("a", "b");

                if (namesArray[i].Length > 3)
                {
                    namesArray[i] = namesArray[i].Substring(3);
                }
            }
            return namesArray;
        }

        protected static void PrintNamesArray(string[] namesArray)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i] != "")
                {
                    namesArray[i] = "*** SUPER " + namesArray[i].ToUpper() + "***";
                    Console.WriteLine(namesArray[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }



        private static string[] CreateArrayOfPeople(string input, char separator)
        {
            return input.Split(separator);
        }

        

        public static void WithoutMethods()
        {
            Console.Write("Enter names: ");
            var input = Console.ReadLine() ?? ""; //är den null blir den ""
            List<string> names = input.Split(',').ToList();

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < names.Count; i++)
            {
                names[i] = "*** SUPER " + names[i].Trim().ToUpper() + "***";
                Console.WriteLine(names[i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        public static List<string> GetNames()
        {
            Console.Write("Enter names: ");
            var input = Console.ReadLine() ?? ""; //är den null blir den ""
            List<string> names = input.Split(',').ToList();

            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].Trim();
            }
            return names;
        }

        public static List<string> UpperNames(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].ToUpper();
            }
            return names;
        }

        public static List<string> SuperNames(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = "SUPER-" + names[i].ToUpper();
            }
            return names;

        }

        public static List<string> AddStars(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = "***" + names[i].ToUpper() + "***";
            }
            return names;

        }

        public static void PrintNames (List<string> names)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var name in names)
                Console.WriteLine(name);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
