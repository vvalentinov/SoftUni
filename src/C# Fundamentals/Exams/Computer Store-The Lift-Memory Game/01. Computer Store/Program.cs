namespace _01._Computer_Store
{
    public class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTax = 0;
            string person;
            while (true)
            {
                person = Console.ReadLine();

                if (person == "regular" || person == "special")
                {
                    break;
                }

                double price = double.Parse(person);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                priceWithoutTax += price;
            }

            double taxes = priceWithoutTax * 0.2;
            double finalPrice = priceWithoutTax + taxes;

            if (person == "special")
            {
                finalPrice -= finalPrice * 0.1;
            }

            if (finalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
        }
    }
}