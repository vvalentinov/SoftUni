namespace _03._Shopping_Spree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag 
        {
            get 
            {
                return (IReadOnlyCollection<Product>)bag;
            }
        }
        public string BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product.Name}";
            }

            Money -= product.Cost;
            bag.Add(product);
            return $"{Name} bought {product.Name}";
        }
        public override string ToString()
        {
            string productsOutput = Bag.Count > 0 ? string.Join(", ", Bag) : "Nothing bought";
            return $"{Name} - {productsOutput}";
        }
    }
}
