using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                    break;
                }
                string[] line = input.Split();
                if (line[0] == "exchange")
                {
                    int index = int.Parse(line[1]);
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        Exchange(numbers, index);
                    }
                }
                else if (line[0] == "max")
                {
                    string command = line[1];
                    if (command == "odd")
                    {
                        MaxOdd(numbers);
                    }
                    else if (command == "even")
                    {
                        MaxEven(numbers);
                    }
                }
                else if (line[0] == "min")
                {
                    string command = line[1];
                    if (command == "odd")
                    {
                        MinOdd(numbers);
                    }
                    else if (command == "even")
                    {
                        MinEven(numbers);
                    }
                }
                else if (line[0] == "first")
                {
                    int count = int.Parse(line[1]);
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string command = line[2];
                        if (command == "even")
                        {
                            int[] result = FirstCountEven(numbers, count);
                            Console.Write("[");
                            bool found = false;
                            foreach (int number in result)
                            {
                                if (number != -1)
                                {
                                    if (found)
                                    {
                                        Console.Write($", {number}");
                                    }
                                    else
                                    {
                                        Console.Write($"{number}");
                                        found = true;
                                    }

                                }
                            }
                            Console.WriteLine("]");
                        }
                        else if (command == "odd")
                        {
                            int[] result = FirstCountOdd(numbers, count);
                            Console.Write("[");
                            bool found = false;
                            foreach (int number in result)
                            {
                                if (number != -1)
                                {
                                    if (found)
                                    {
                                        Console.Write($", {number}");
                                    }
                                    else
                                    {
                                        Console.Write($"{number}");
                                        found = true;
                                    }

                                }
                            }
                            Console.WriteLine("]");
                        }
                    }
                }
                else if (line[0] == "last")
                {
                    int count = int.Parse(line[1]);
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string command = line[2];
                        if (command == "even")
                        {
                            int[] result = LastCountEven(numbers, count);
                            Console.Write("[");
                            bool found = false;
                            foreach (int number in result)
                            {
                                if (number != -1)
                                {
                                    if (found)
                                    {
                                        Console.Write($", {number}");
                                    }
                                    else
                                    {
                                        Console.Write($"{number}");
                                        found = true;
                                    }

                                }
                            }
                            Console.WriteLine("]");
                        }
                        else if (command == "odd")
                        {
                            int[] result = LastCountOdd(numbers, count);
                            Console.Write("[");
                            bool found = false;
                            foreach (int number in result)
                            {
                                if (number != -1)
                                {
                                    if (found)
                                    {
                                        Console.Write($", {number}");
                                    }
                                    else
                                    {
                                        Console.Write($"{number}");
                                        found = true;
                                    }

                                }
                            }
                            Console.WriteLine("]");
                        }
                    }

                }
            }

        }

        private static int[] FirstCountOdd(int[] numbers, int count)
        {
            int[] firstOddNumbers = new int[count];
            for (int i = 0; i < firstOddNumbers.Length; i++)
            {
                firstOddNumbers[i] = -1;
            }
            int index = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    firstOddNumbers[index] = number;
                    index++;
                    if (index >= firstOddNumbers.Length)
                    {
                        break;
                    }
                }
            }
            return firstOddNumbers;
        }

        private static int[] LastCountEven(int[] numbers, int count)
        {
            int[] lastEvenNumbers = new int[count];
            for (int i = lastEvenNumbers.Length - 1; i >= 0; i--)
            {
                lastEvenNumbers[i] = -1;
            }
            int index = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int number = numbers[i];
                if (number % 2 == 0)
                {
                    lastEvenNumbers[index] = number;
                    index++;
                    if (index >= lastEvenNumbers.Length)
                    {
                        break;
                    }
                }
            }

            return lastEvenNumbers.Reverse().ToArray();
        }

        private static int[] LastCountOdd(int[] numbers, int count)
        {
            int[] lastOddNumbers = new int[count];
            for (int i = lastOddNumbers.Length - 1; i >= 0; i--)
            {
                lastOddNumbers[i] = -1;
            }
            int index = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int number = numbers[i];
                if (number % 2 != 0)
                {
                    lastOddNumbers[index] = number;
                    index++;
                    if (index >= lastOddNumbers.Length)
                    {
                        break;
                    }
                }
            }

            return lastOddNumbers.Reverse().ToArray();
        }

        private static int[] FirstCountEven(int[] numbers, int count)
        {
            int[] firstEvenNumbers = new int[count];
            for (int i = 0; i < firstEvenNumbers.Length; i++)
            {
                firstEvenNumbers[i] = -1;
            }
            int index = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    firstEvenNumbers[index] = number;
                    index++;
                    if (index >= firstEvenNumbers.Length)
                    {
                        break;
                    }
                }
            }
            return firstEvenNumbers;
        }

        private static void MinEven(int[] numbers)
        {
            int minEven = int.MaxValue;
            int minIndex = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minEven)
                {
                    minEven = numbers[i];
                    minIndex = i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }

        }

        private static void MinOdd(int[] numbers)
        {
            int minOdd = int.MaxValue;
            int minIndex = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= minOdd)
                {
                    minOdd = numbers[i];
                    minIndex = i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        private static void MaxEven(int[] numbers)
        {
            int maxEven = int.MinValue;
            int maxIndex = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= maxEven)
                {
                    maxEven = numbers[i];
                    maxIndex = i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        private static void MaxOdd(int[] numbers)
        {
            int maxOdd = int.MinValue;
            int maxIndex = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] >= maxOdd)
                {
                    maxOdd = numbers[i];
                    maxIndex = i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        private static void Exchange(int[] numbers, int index)
        {
            for (int i = 0; i < index + 1; i++)
            {
                int curr = numbers[0];
                for (int j = 1; j <= numbers.Length - 1; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length - 1] = curr;
            }
        }
    }
}