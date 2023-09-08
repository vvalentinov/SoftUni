namespace _01.Encrypt__Sort_and_Print_Array
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] vowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                foreach (var letter in name)
                {
                    if (vowels.Contains(letter))
                    {
                        sum += letter * name.Length;
                    }
                    else
                    {
                        sum += letter / name.Length;
                    }
                }
                arr[i] = sum;
                sum = 0;
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
