namespace _01.Oscars_Ceremony
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double figures = rent - rent * 0.3;
            double catering = figures - figures * 0.15;
            double sound = catering / 2;
            double total = rent + figures + catering + sound;
            Console.WriteLine($"{total:f2}");
        }
    }
}
