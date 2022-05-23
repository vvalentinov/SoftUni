namespace _04.Sum_of_Two_Numbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumberInPair = int.Parse(Console.ReadLine());
            int secondNumberInPair = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int countCombination = 0;
            bool isFound = false;
            for (int firstNumber = firstNumberInPair; firstNumber <= secondNumberInPair; firstNumber++)
            {
                for (int secondNumber = firstNumberInPair; secondNumber <= secondNumberInPair; secondNumber++)
                {
                    countCombination++;
                    if (firstNumber + secondNumber == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{countCombination} ({firstNumber} + {secondNumber} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{countCombination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
