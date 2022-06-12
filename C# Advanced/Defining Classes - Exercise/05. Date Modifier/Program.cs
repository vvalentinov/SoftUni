namespace _05._Date_Modifier
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            Console.WriteLine(dateModifier.CalculateDifference(first, second));
        }
    }
}
