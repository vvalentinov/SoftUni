namespace _11._TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split().ToList();

            Func<string, int> getAsciiSum = p => p.Select(c => (int)c).Sum();
           
            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func) => people.FirstOrDefault(p => func(p) >= n);
            Console.WriteLine(nameFunc(people, n, getAsciiSum));
        }
    }
}
