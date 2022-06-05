namespace _04.Star_Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[^\s]*@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[AD])![^@\-!:>]*->(?<soldierCount>\d+)";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string decrypted = Decrypting(line);
                if (regex.IsMatch(decrypted))
                {
                    string planet = regex.Match(decrypted).Groups["name"].Value;
                    string attackType = regex.Match(decrypted).Groups["attackType"].Value;
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }
            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
                foreach (var item in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
            {
                Console.WriteLine("Attacked planets: 0");
            }

            if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
                foreach (var item in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
            {
                Console.WriteLine("Destroyed planets: 0");
            }
        }
        private static string Decrypting(string line)
        {
            int count = 0;
            string check = "STARstar";
            StringBuilder decrypted = new StringBuilder();
            foreach (char letter in line)
            {
                if (check.Contains(letter))
                {
                    count++;
                }
            }
            foreach (char letter in line)
            {
                char newChar = (char)(letter - count);
                decrypted.Append(newChar);
            }
            return decrypted.ToString();
        }
    }
}
