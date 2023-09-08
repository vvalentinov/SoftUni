namespace _12.Refactor_Special_Numbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
			int inputNum = int.Parse(Console.ReadLine());
			int sum = 0;
            for (int num = 1; num <= inputNum; num++)
			{
                int specialNum = num;
                while (num > 0)
				{
					sum += num % 10;
					num /= 10;
				}
                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{specialNum} -> {special}");
				sum = 0;
				num = specialNum;
			}
		}
    }
}
