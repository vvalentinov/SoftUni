namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int totalCars = 0;
            bool hasCrashed = false;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                if (line == "green")
                {
                    int currGreen = greenLight;
                    while (queue.Count > 0)
                    {
                        int lenghtCar = queue.Peek().Length;
                        if (lenghtCar <= currGreen)
                        {
                            currGreen -= lenghtCar;
                            queue.Dequeue();
                            totalCars++;
                        }
                        else
                        {
                            string car = queue.Dequeue();
                            string alteredCar = car.Remove(0, currGreen);
                            if (alteredCar.Length <= freeWindow)
                            {
                                totalCars++;
                                currGreen = 0;
                            }
                            else
                            {
                                alteredCar = alteredCar.Remove(0, freeWindow);
                                hasCrashed = true;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {alteredCar[0]}.");
                                break;
                            }
                        }
                        if (currGreen <= 0)
                        {
                            break;
                        }
                    }
                    if (hasCrashed)
                    {
                        break;
                    }
                }
                else
                {
                    queue.Enqueue(line);
                }
            }
            if (!hasCrashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
