namespace _09.Chars_to_String
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            Console.WriteLine(one.ToString() + two.ToString() + three.ToString());
        }
    }
}
