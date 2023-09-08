namespace _05.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        class Person
        {
            public Person()
            {
                BagProducts = new List<string>();
            }
            public string Name { get; set; }
            public int Money { get; set; }
            public List<string> BagProducts { get; set; }

            public bool CanAfford(List<Person> people, string name, int costProduct, string product)
            {
                foreach (Person person in people)
                {
                    if (person.Name == name)
                    {
                        if (person.Money >= costProduct)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        class Product
        {
            public string Name { get; set; }
            public int Cost { get; set; }
        }
        static void Main(string[] args)
        {
            string[] arrPeople = Console.ReadLine().Split(";");
            string[] arrProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < arrPeople.Length; i++)
            {
                string[] personData = arrPeople[i].Split("=");
                string name = personData[0];
                int money = int.Parse(personData[1]);
                Person person = new Person()
                {
                    Name = name,
                    Money = money
                };

                people.Add(person);
            }

            for (int i = 0; i < arrProducts.Length; i++)
            {
                string[] productData = arrProducts[i].Split("=");
                string name = productData[0];
                int cost = int.Parse(productData[1]);
                Product product = new Product()
                {
                    Name = name,
                    Cost = cost
                };
                products.Add(product);
            }

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] arr = line.Split();
                string name = arr[0];
                string product = arr[1];
                int costProduct = 0;
                foreach (Product item in products)
                {
                    if (item.Name == product)
                    {
                        costProduct = item.Cost;
                    }
                }
                foreach (Person person in people)
                {
                    if (person.Name == name && person.CanAfford(people, name, costProduct, product))
                    {
                        person.Money -= costProduct;
                        person.BagProducts.Add(product);
                        Console.WriteLine($"{person.Name} bought {product}");
                        break;
                    }
                    else if (person.Name == name && !person.CanAfford(people, name, costProduct, product))
                    {
                        Console.WriteLine($"{person.Name} can't afford {product}");
                        break;
                    }
                }
                line = Console.ReadLine();
            }

            List<Person> filteredPeoplePositiveBagProducts = people.Where(x => x.BagProducts.Count > 0).ToList();
            List<Person> filteredPeopleZeroBagProducts = people.Where(x => x.BagProducts.Count == 0).ToList();
            foreach (Person person in filteredPeoplePositiveBagProducts)
            {
                Console.WriteLine($"{person.Name} - " + string.Join(", ", person.BagProducts));
            }

            foreach (Person person in filteredPeopleZeroBagProducts)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }
    }
}
