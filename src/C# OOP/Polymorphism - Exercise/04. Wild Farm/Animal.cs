namespace _04._Wild_Farm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract void ProduceSound();
    }
}
