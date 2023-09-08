namespace _08._Car_Salesman
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[n];
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string model = parts[0];
                    int power = int.Parse(parts[1]);
                    Engine engine = new Engine(model, power, "n/a", "n/a");
                    engines[i] = engine;
                }
                else if (parts.Length == 3)
                {
                    string model = parts[0];
                    int power = int.Parse(parts[1]);
                    string thirdParameter = parts[2];
                    if (int.TryParse(thirdParameter, out int displacement))
                    {
                        Engine engine = new Engine(model, power, displacement.ToString(), "n/a");
                        engines[i] = engine;
                    }
                    else
                    {
                        string efficiency = parts[2];
                        Engine engine = new Engine(model, power, "n/a", efficiency);
                        engines[i] = engine;
                    }
                }
                else
                {
                    string model = parts[0];
                    int power = int.Parse(parts[1]);
                    string displacement = parts[2];
                    string efficiency = parts[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines[i] = engine;
                }

            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    string model = parts[0];
                    string engineModel = parts[1];
                    Engine engine = GetEngine(engineModel, engines);
                    if (engine != null)
                    {
                        Car car = new Car(model, engine, "n/a", "n/a");
                        cars.Add(car);
                    }
                }
                else if (parts.Length == 3)
                {
                    string model = parts[0];
                    string engineModel = parts[1];
                    Engine engine = GetEngine(engineModel, engines);
                    if (engine != null)
                    {
                        string thirdParameter = parts[2];
                        if (int.TryParse(thirdParameter, out int weight))
                        {
                            Car car = new Car(model, engine, weight.ToString(), "n/a");
                            cars.Add(car);
                        }
                        else
                        {
                            string color = parts[2];
                            Car car = new Car(model, engine, "n/a", color);
                            cars.Add(car);
                        }
                    }
                }
                else
                {
                    string model = parts[0];
                    string engineModel = parts[1];
                    Engine engine = GetEngine(engineModel, engines);
                    if (engine != null)
                    {
                        string weight = parts[2];
                        string color = parts[3];
                        Car car = new Car(model, engine, weight, color);
                        cars.Add(car);
                    }
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
        private static Engine GetEngine(string engineModel, Engine[] engines)
        {

            foreach (Engine engine in engines)
            {
                if (engine.Model == engineModel)
                {
                    return engine;
                }
            }
            return null;
        }
    }
}
