namespace _04.Tribonacci_Sequence
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger[] array = new BigInteger[num];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                BigInteger sum = CalculateSum(i, array); ;
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
        private static BigInteger CalculateSum(int i, BigInteger[] array)
        {
            BigInteger firstNum = 0;
            BigInteger secondNum = 0;
            BigInteger thirdNum = 0;
            if (i - 1 >= 0)
            {
                firstNum = array[i - 1];
            }
            if (i - 2 >= 0)
            {
                secondNum = array[i - 2];
            }
            if (i - 3 >= 0)
            {
                thirdNum = array[i - 3];
            }
            return firstNum + secondNum + thirdNum;
        }
    }
}
