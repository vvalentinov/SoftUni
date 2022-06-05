namespace _09.Greater_of_Two_Values
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxInt(firstNumber, secondNumber));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMaxString(firstString, secondString));
                    break;
                default:
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(firstChar, secondChar));
                    break;
            }
        }

        private static char GetMaxChar(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        private static string GetMaxString(string firstString, string secondString)
        {
            if (string.Compare(firstString, secondString) < 0)
            {
                return secondString;
            }
            else
            {
                return firstString;
            }
        }

        private static int GetMaxInt(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
