namespace _04._Random_List
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("something1");
            list.Add("something2");
            list.Add("something3");
            list.Add("something4");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.Count);
        }
    }
}
