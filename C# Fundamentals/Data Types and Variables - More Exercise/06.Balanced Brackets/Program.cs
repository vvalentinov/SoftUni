namespace _06.Balanced_Brackets
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOpening = 0;
            int countClosing = 0;
            for (int i = 1; i <= n; i++)
            {
                string a = Console.ReadLine();
                if (a == "(")
                {
                    countOpening++;
                }
                else if (a == ")")
                {
                    countClosing++;
                    if (countOpening - countClosing != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }
            if (countOpening == countClosing)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
