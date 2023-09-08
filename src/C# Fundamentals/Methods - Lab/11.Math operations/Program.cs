namespace _11.Math_operations
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char command = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CommandResult(firstNumber, command, secondNumber));
        }
        private static double CommandResult(int firstNumber, char command, int secondNumber)
        {
            switch (command)
            {
                case '+':
                    return Math.Round(firstNumber * 1.0 + secondNumber, 2);
                case '*':
                    return Math.Round(firstNumber * 1.0 * secondNumber, 2);
                case '-':
                    return Math.Round(firstNumber * 1.0 - secondNumber, 2);
                default:
                    return Math.Round(firstNumber * 1.0 / secondNumber, 2);
            }
        }
    }
}
