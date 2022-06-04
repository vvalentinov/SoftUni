namespace _08.Pet_Shop
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            double dogFood = 2.50;
            double otherAnimals = 4;
            Console.WriteLine($"{numberOfDogs * dogFood + numberOfOtherAnimals * otherAnimals} lv.");
        }
    }
}
