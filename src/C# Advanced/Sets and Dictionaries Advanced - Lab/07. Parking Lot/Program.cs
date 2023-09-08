namespace _07._Parking_Lot
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] parts = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = parts[0];
                string carNumber = parts[1];
                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else
                {
                    cars.Remove(carNumber);
                }
            }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
