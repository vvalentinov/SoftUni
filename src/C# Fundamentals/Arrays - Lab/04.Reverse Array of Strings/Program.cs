namespace _04.Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(' ', Console.ReadLine().Split().Reverse()));
        }
    }
}
