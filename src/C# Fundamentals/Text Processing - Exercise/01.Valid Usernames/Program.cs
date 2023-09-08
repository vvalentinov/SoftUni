namespace _01.Valid_Usernames
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ");
            List<string> output = new List<string>();
            bool toAdd = true;
            foreach (var item in line)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsDigit(item[i]) ||
                            char.IsLetter(item[i]) ||
                            item[i] == '-' ||
                            item[i] == '_')
                        {
                            toAdd = true;
                        }
                        else
                        {
                            toAdd = false;
                            break;
                        }
                    }
                    if (toAdd == true)
                    {
                        output.Add(item);
                    }
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
