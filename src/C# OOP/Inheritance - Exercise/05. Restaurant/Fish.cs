namespace _05._Restaurant
{
    public class Fish : MainDish
    {
        private const double DeafultGrams = 22;
        public Fish(string name, decimal price) : base(name, price, DeafultGrams)
        {
        }
    }
}
