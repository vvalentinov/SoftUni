namespace _07._Tuple
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string city = personInfo[2];
            Tuple<string, string> tuple = new Tuple<string, string>(fullName, city);
            Console.WriteLine(tuple.ToString());

            string[] arr = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string name = arr[0];
            int litresBeer = int.Parse(arr[1]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(name, litresBeer);
            Console.WriteLine(tuple2.ToString());

            string[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int integer = int.Parse(arr2[0]);
            double doubleNumber = double.Parse(arr2[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(integer, doubleNumber);
            Console.WriteLine(tuple3.ToString());
        }
    }
}
