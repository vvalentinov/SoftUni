namespace _04._Wild_Farm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
