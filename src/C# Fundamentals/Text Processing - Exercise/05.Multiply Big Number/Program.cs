namespace _05.Multiply_Big_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string longNum = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            if (num == 0 || longNum == "")
            {
                Console.WriteLine(0);
                return;
            }
            IEnumerable<char> reversed = longNum.Reverse();
            foreach (var ch in reversed)
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * num + temp;
                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }
            if (temp > 0)
            {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
