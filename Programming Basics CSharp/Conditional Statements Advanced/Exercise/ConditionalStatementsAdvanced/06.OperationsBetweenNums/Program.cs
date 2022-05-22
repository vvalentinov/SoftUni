namespace _06.OperationsBetweenNums
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    if ((firstNumber + secondNumber) % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber} - odd");
                    }
                    break;
                case '-':
                    if ((firstNumber - secondNumber) % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber} - odd");
                    }
                    break;
                case '*':
                    if (firstNumber * secondNumber % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber} - odd");
                    }
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber:f2}");
                    }
                    break;
                case '%':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                    }
                    break;
            }
        }
    }
}
