using System;
using System.Collections.Generic;

namespace Tabort2
{
    class Product
    {
        public int ProductId { get; set; }

        /*
        int _productId;
        public int GetProductId()
        {
            return _productId;
        }
        public void SetProductId(int value)
        {
            _productId = value;
        } */
    }
    class Book : Product
    {
        public string Isbn { get; set; }
        public string Author { get; set; }



        private int _nrOfPages;

        public void SetNrOfPages(int value)
        {
            if (value > 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Så stora böcker finns det inte, sätter värdet till 400");
                _nrOfPages = 400;
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            else
                _nrOfPages = value;
        }

        public int NrOfPages => _nrOfPages;



        public int Weight => _nrOfPages * 10;

        public string Review
        {
            get
            {
                var result = "";
                if (_nrOfPages > 100)
                    result = "Superbra";
                else
                    result = "Tja";
                return result;
            }
        }



    }

    class ElectronicBook : Book
    {
           
        public void SendAsEmail(string adress)
        {
            Console.WriteLine($"Send e-mail till {adress}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();
            var b2 = new Book();

            b1.Isbn = "XXXXXXXXXXXXX-X";
            b1.Author = "Ida";
            b1.SetNrOfPages(1300);

            Console.WriteLine($"*** Info om boken:");
            Console.WriteLine($"*** {b1.ProductId}");
            Console.WriteLine($"*** Föffattare {b1.Author}");
            Console.WriteLine($"*** ISBN är {b1.Isbn}");
            Console.WriteLine($"***Boken har {b1.NrOfPages} sidor");
            Console.WriteLine($"*** Vikten är {b1.Weight}");
            //Console.WriteLine($"*** Recention = {b1.Review()}");

            var b3 = new ElectronicBook();

            Console.WriteLine("Test");
            Console.WriteLine($"b3 är en e-bok? {b3 is ElectronicBook}" );
            Console.WriteLine($"b2 är en e-bok? {b2 is ElectronicBook}");

            b3.SendAsEmail("idas adress ");
            Console.WriteLine($"***b3 Id {b3.ProductId}");
            Console.WriteLine($"***b3 Författare {b3.Author}");

  

            var list = new List<Book>();
        }
    }
}
