namespace _05.Salary
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;
            for (int i = 0; i <= numberOfTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        salary -= FACEBOOK;
                        break;
                    case "Instagram":
                        salary -= INSTAGRAM;
                        break;
                    case "Reddit":
                        salary -= REDDIT;
                        break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
