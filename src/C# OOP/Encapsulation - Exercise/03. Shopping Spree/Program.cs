namespace _03._Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                ReadPeople(people);
                ReadProduct(products);
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                    {
                        break;
                    }
                    string[] cmdArg = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = cmdArg[0];
                    string productName = cmdArg[1];
                    Person person = people.FirstOrDefault(x => x.Name == personName);
                    Product product = products.FirstOrDefault(x => x.Name == productName);
                    if (person != null && product != null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }
                foreach (Person person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static void ReadProduct(List<Product> products)
        {
            string[] productArg = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in productArg)
            {
                string[] productData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = productData[0];
                decimal cost = decimal.Parse(productData[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }
        }

        private static void ReadPeople(List<Person> people)
        {

            string[] peopleArg = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (string personData in peopleArg)
            {
                string[] personArg = personData.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = personArg[0];
                decimal money = decimal.Parse(personArg[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }
        }
    }
}
