namespace _08.Basketball_Equipment
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTrainingFee = int.Parse(Console.ReadLine());
            double basketballShoes = annualTrainingFee - (annualTrainingFee * 0.4);
            double basketballUniform = basketballShoes - (basketballShoes * 0.2);
            double basketballPrice = basketballUniform / 4;
            double basketballAccessories = basketballPrice / 5;
            Console.WriteLine(annualTrainingFee + basketballShoes + basketballUniform + basketballPrice + basketballAccessories);
        }
    }
}
