namespace _02.Vowels_Count
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            char[] arr1 = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            Console.WriteLine(VowelsCount(arr, arr1));
        }
        static int VowelsCount(char[] a, char[] b)
        {
            int countVowels = 0;
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        countVowels++;
                    }
                }
            }
            return countVowels;
        }
    }
}
