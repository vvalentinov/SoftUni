namespace _04.Morse_Code_Translator
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morse = Console.ReadLine().Split();
            StringBuilder message = new StringBuilder();
            foreach (var item in morse)
            {
                switch (item)
                {
                    case ".-":
                        message.Append('A');
                        break;
                    case "-...":
                        message.Append('B');
                        break;
                    case "-.-.":
                        message.Append('C');
                        break;
                    case "-..":
                        message.Append('D');
                        break;
                    case ".":
                        message.Append('E');
                        break;
                    case "..-.":
                        message.Append('F');
                        break;
                    case "--.":
                        message.Append('G');
                        break;
                    case "....":
                        message.Append('H');
                        break;
                    case "..":
                        message.Append('I');
                        break;
                    case ".---":
                        message.Append('J');
                        break;
                    case "-.-":
                        message.Append('K');
                        break;
                    case ".-..":
                        message.Append('L');
                        break;
                    case "--":
                        message.Append('M');
                        break;
                    case "-.":
                        message.Append('N');
                        break;
                    case "---":
                        message.Append('O');
                        break;
                    case ".--.":
                        message.Append('P');
                        break;
                    case "--.-":
                        message.Append('Q');
                        break;
                    case ".-.":
                        message.Append('R');
                        break;
                    case "...":
                        message.Append('S');
                        break;
                    case "-":
                        message.Append('T');
                        break;
                    case "..-":
                        message.Append('U');
                        break;
                    case "...-":
                        message.Append('V');
                        break;
                    case ".--":
                        message.Append('W');
                        break;
                    case "-..-":
                        message.Append('X');
                        break;
                    case "-.--":
                        message.Append('Y');
                        break;
                    case "--..":
                        message.Append('Z');
                        break;
                    default:
                        message.Append(' ');
                        break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
