namespace _02._Animal_Farm
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            try
            {
                Chicken chicken = new Chicken(name, age);
                Console.WriteLine(chicken);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
