namespace _01._ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] creatingList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            if (creatingList.Length > 1)
            {
                for (int i = 1; i < creatingList.Length; i++)
                {
                    list.Add(creatingList[i]);
                }
            }
            ListyIterator<string> listy = new ListyIterator<string>(list);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                switch (line)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        listy.Print();
                        break;
                }
            }
        }
    }
}
