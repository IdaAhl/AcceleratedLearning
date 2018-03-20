using System;

namespace Modul6_4
{
    enum Sport
    {
        Tennis, Rugby, Soccer, Hurling, Squash
    }

    enum Gender
    {
        Female, Male, Other
    }

    class Person
    {
        string _firstName;
        string _lastName;
        DateTime _birthday;
        Gender _gender;
        Sport _favoriteSport;

        public Person (string firsName, string lastName, DateTime birthday, Gender gender, Sport favoriteSport)
        {
            this._firstName = firsName;
            this._lastName = lastName;
            this._birthday = birthday;
            this._gender = gender;
            this._favoriteSport = favoriteSport;
        }

        public Sport FavoriteSport
        {
            get { return _favoriteSport; }
            set { _favoriteSport = value; }

        }

        public void PrintGender()
        {
            Console.WriteLine($"{_firstName} is {_gender}");
        }

        public void PrintFavoriteSport()
        {
            Console.WriteLine($"{_firstName} likes {_favoriteSport}");

        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            Person lisa = new Person("Lisa", "Svan", DateTime.Now, Gender.Other, Sport.Tennis);
            lisa.PrintGender();
            lisa.PrintFavoriteSport();

            Console.WriteLine();

            var sports = Enum.GetNames(typeof(Sport));
            for (int i = 0; i < sports.Length  ; i++)
            {
                Console.WriteLine($"* {sports[i]} ");

            }

            Console.Write("Enter a sport: ");
            Console.ForegroundColor = ConsoleColor.Red;

            var userInput = (Console.ReadLine().Trim());

            Console.ForegroundColor = ConsoleColor.Gray;



            if (Enum.TryParse(userInput, true, out Sport sport))
            {
                Console.WriteLine($"Oh, I know {sport}!");

            }
            else
            {
                Console.WriteLine($"I don't know the sport {userInput}");

            }

               


        }
    }
}
