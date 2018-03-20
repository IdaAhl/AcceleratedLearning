using System;

namespace Modul6_5
{
    class Adress
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }


        public string GetFullStreet()
        {
            return Street + " " + StreetNumber;
        }

        public string FullStreet => Street + " " + StreetNumber;

        public string FullCity
        {
            get
            {
                var fullCity = "";
                fullCity = City + " " + ZipCode;
                return fullCity;
            }
        }

       
        public void SetZipCode(string newZipCode)
        {
            newZipCode.Trim();
            var numbers = newZipCode.ToCharArray();

            if (numbers.Length == 6 && numbers[3] == ' ')
            {
                Console.WriteLine("New zipcode");
                ZipCode = newZipCode;
            }
            else
                Console.WriteLine("Invalid zipcode");
               

        }
         




    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress myAdress = new Adress
            {
                Street = "Soldatehemsgatan",
                StreetNumber = "18",
                City = "Göteborg",
                ZipCode = "415 28"
            };

            /*
            Console.WriteLine(myAdress.GetFullStreet());
            Console.WriteLine();
            myAdress.Street = "Storagatan";
            Console.WriteLine(myAdress.FullStreet);
            Console.WriteLine(myAdress.FullCity);
            */

            Console.Write("Change ZipCode to: ");
            var newZipCode = Console.ReadLine();
            myAdress.ZipCode = newZipCode;

            Console.WriteLine(myAdress.ZipCode);
            
        }
    }
}
