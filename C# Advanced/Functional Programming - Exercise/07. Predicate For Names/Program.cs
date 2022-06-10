namespace _07._Predicate_For_Names
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<int, bool> checkLenght = x => x <= n;
            foreach (string name in names)
            {
                if (checkLenght(name.Length))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
