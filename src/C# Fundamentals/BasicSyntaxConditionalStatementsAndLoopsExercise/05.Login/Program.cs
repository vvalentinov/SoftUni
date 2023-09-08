namespace _05.Login
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            int count = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                builder.Append(username[i]);
            }
            while (true)
            {
                string currPassword = Console.ReadLine();
                count++;
                if (currPassword != builder.ToString() && count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (currPassword != builder.ToString())
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                if (currPassword == builder.ToString())
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
