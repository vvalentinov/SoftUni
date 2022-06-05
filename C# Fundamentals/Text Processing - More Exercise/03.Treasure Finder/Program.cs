namespace _03.Treasure_Finder
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "find")
            {
                string final = DecryptInput(input, keys);

                PrintOutput(final);
                input = Console.ReadLine();
            }
        }
        private static void PrintOutput(string final)
        {
            int startIndexTreasure = final.IndexOf('&') + 1;
            int endIndexTreasure = final.LastIndexOf('&');
            int startIndexCoordinate = final.IndexOf('<') + 1;
            int endIndexCoordinate = final.IndexOf('>');
            string treasure = final.Substring(startIndexTreasure, endIndexTreasure - startIndexTreasure);
            string coordinate = final.Substring(startIndexCoordinate, endIndexCoordinate - startIndexCoordinate);
            Console.WriteLine($"Found {treasure} at {coordinate}");
        }
        private static string DecryptInput(string input, int[] keys)
        {
            StringBuilder message = new StringBuilder();
            int inputLenght = input.Length;

            while (message.Length != inputLenght)
            {
                if (input.Length >= keys.Length)
                {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        char current = input[i];
                        int power = int.Parse(keys[i].ToString());
                        char newChar = (char)(current - power);
                        message.Append(newChar);
                    }

                    input = input.Remove(0, keys.Length);
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        char current = input[i];
                        int power = int.Parse(keys[i].ToString());
                        char newChar = (char)(current - power);
                        message.Append(newChar);
                    }
                }

            }
            return message.ToString();
        }
    }
}
