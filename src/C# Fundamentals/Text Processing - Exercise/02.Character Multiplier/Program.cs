namespace _02.Character_Multiplier
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            CharacterMultiplier(input);
        }
        private static void CharacterMultiplier(string[] input)
        {
            int sum = 0;
            string firstWord = input[0];
            string secondWord = input[1];
            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
            }
            else if (secondWord.Length > firstWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                secondWord = secondWord.Substring(firstWord.Length);
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += secondWord[i];
                }
            }
            else if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                firstWord = firstWord.Substring(secondWord.Length);
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
