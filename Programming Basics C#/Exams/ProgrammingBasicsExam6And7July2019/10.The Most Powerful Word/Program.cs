namespace _10.The_Most_Powerful_Word
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string mostPowerfulWord = string.Empty;
            double maxPower = 0;

            string input = Console.ReadLine();
            while (input != "End of words")
            {
                double inputSum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    inputSum += input[i];
                }

                string input2 = input.ToLower();
                if (input2[0] == 'a' ||
                    input2[0] == 'e' ||
                    input2[0] == 'i' ||
                    input2[0] == 'o' ||
                    input2[0] == 'u' ||
                    input2[0] == 'y')
                {
                    inputSum *= input.Length;
                }
                else
                {
                    inputSum = Math.Floor(inputSum / input.Length);
                }

                if (inputSum > maxPower)
                {
                    maxPower = inputSum;
                    mostPowerfulWord = input;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {maxPower}");
        }
    }
}
