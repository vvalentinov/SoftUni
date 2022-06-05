namespace _04.Santa_s_Secret_Helper
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^[^@\-:>]*@(?<name>[a-zA-Z]+)[^@\-!:>]*!(?<behaviour>[GN])![^@\-!:>]*$");
            List<string> names = new List<string>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string decrypted = Decrypt(input, key);

                if (regex.IsMatch(decrypted))
                {
                    string behaviour = regex.Match(decrypted).Groups["behaviour"].Value;

                    if (behaviour == "G")
                    {
                        names.Add(regex.Match(decrypted).Groups["name"].Value);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", names));
        }
        private static string Decrypt(string input, int key)
        {
            StringBuilder decrypted = new StringBuilder();

            foreach (char symbol in input)
            {
                char newSymbol = (char)(symbol - key);
                decrypted.Append(newSymbol);
            }

            return decrypted.ToString();
        }
    }
}
