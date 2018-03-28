using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Modul11
{
    public enum Gender
    {
        female,
        male
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Gender CustomerGender { get; set; }
        public int Age { get; set; }

        public Customer()
        {
        }

    }

    public class Parser
    {
        /*
        public static List<Customer> CreateListOfCostumers()
        {

            var costumerList = new List<Customer>();
            try
            {
                var text = System.IO.File.ReadAllLines(@"C:\TMP\Names.csv");
                CreateListOfCostumers()
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Hittar inte filen");
            
            }

           
                

                for (int i = 1; i < text.Length - 1; i++)
                {
                    //if (string.IsNullOrEmpty(text[i]))
                    //  continue;


                    var costumerArray = text[i].Split(",");


                    var customer = new Customer()
                    {
                        CustomerId = int.Parse(costumerArray[0]),
                        FirstName = costumerArray[1],
                        LastName = costumerArray[2],
                        Age = int.Parse(costumerArray[4])

                    };

                    costumerList.Add(customer);

                }



            }
            catch (ArgumentException)
            {
                Console.WriteLine("fEL");
            }
            catch (FormatException)
            {
                Console.WriteLine("fEL");
                continue;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Hittade inte filen");
            }

            return costumerList;
        }
        */

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Customer> customersList = new List<Customer>();
            // customersList = Parser.CreateListOfCostumers();

           

            var list = customersList.OrderBy(name => name.FirstName)
                .ToList();

            Console.WriteLine("Customers sorted by name");
            foreach (var costumer in list)
            {
                Console.WriteLine($"Name {costumer.FirstName} {costumer.Age}");
            }
            Console.WriteLine();


            var listAge = list.Where(age => age.Age > 35).ToList();

            Console.WriteLine("Customers sorted and over 35");
            foreach (var costumer in listAge)
            {
                Console.WriteLine($"Name {costumer.FirstName} {costumer.Age}");
            }
            Console.WriteLine();


            var listUpper = customersList.Select(customer => customer).ToList();
                listUpper.ForEach(customer => customer.FirstName = customer.FirstName.ToUpper());
                listUpper.ForEach(customer => customer.Age = customer.Age + 100 );

            Console.WriteLine("Customers to upper + 100 year");
            foreach (var costumer in listUpper)
            {
                Console.WriteLine($"Name {costumer.FirstName} {costumer.Age}"); 
            }



        }
    }
}