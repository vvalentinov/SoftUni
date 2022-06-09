namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int valueIntelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(bulletsInfo);
            Queue<int> locks = new Queue<int>(locksInfo);
            int countBullets = 0;
            int bulletCost = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Peek();
                bulletCost += priceBullet;
                int currLock = locks.Peek();
                countBullets++;
                if (bullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                if (countBullets == sizeBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    countBullets = 0;
                }
            }
            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueIntelligence - bulletCost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
