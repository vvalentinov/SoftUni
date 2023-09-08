namespace _01.Data_Type_Finder
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            while (a != "END")
            {
                if (int.TryParse(a, out int value1))
                {
                    Console.WriteLine($"{a} is integer type");
                }
                else if (float.TryParse(a, out float value2))
                {
                    Console.WriteLine($"{a} is floating point type");
                }
                else if (char.TryParse(a, out char value3))
                {
                    Console.WriteLine($"{a} is character type");
                }
                else if (bool.TryParse(a, out bool value4))
                {
                    Console.WriteLine($"{a} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{a} is string type");
                }
                a = Console.ReadLine();
            }
        }
    }
}
