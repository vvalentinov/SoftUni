namespace _03.Post_Office
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            string firstPart = input[0];
            string secondPart = input[1];
            string[] thirdPart = input[2].Split();
            Regex regexFirstPart = new Regex(@"(#|\$|%|\*|&)(?<capitalLetters>[A-Z]+)\1");
            Regex regexSecondPart = new Regex(@"(?<letter>\d{2}):(?<lenght>\d{2})");

            char[] capitalLetters = regexFirstPart.Match(firstPart).Groups["capitalLetters"].Value.ToString().ToCharArray();

            MatchCollection matches = regexSecondPart.Matches(secondPart);
            for (int i = 0; i < capitalLetters.Length; i++)
            {
                char currentLetter = capitalLetters[i];
                int lenght = GetLenght(matches, currentLetter);

                if (lenght != -1 && lenght >= 1 && lenght <= 20)
                {
                    Regex regexThirdPart = new Regex($@"^{currentLetter}[^\s]{{{lenght}}}$");
                    string match = GetMatch(thirdPart, regexThirdPart);

                    if (match != null)
                    {
                        Console.WriteLine(match);
                    }
                }
            }
        }
        private static string GetMatch(string[] thirdPart, Regex regexThirdPart)
        {
            foreach (var item in thirdPart)
            {
                if (regexThirdPart.IsMatch(item))
                {
                    return item;
                }
            }
            return null;
        }

        private static int GetLenght(MatchCollection matches, char currentLetter)
        {
            foreach (Match item in matches)
            {
                int asciiCode = int.Parse(item.Groups["letter"].Value);
                char symbol = (char)asciiCode;

                if (symbol == currentLetter)
                {
                    return int.Parse(item.Groups["lenght"].Value);
                }
            }
            return -1;
        }
    }
}
