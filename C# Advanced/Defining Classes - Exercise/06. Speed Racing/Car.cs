namespace _06._Speed_Racing
{
    using System;

    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void MovingCar(Car car, double amountKM)
        {
            double fuelNeeded = amountKM * car.FuelConsumptionPerKilometer;
            if (car.FuelAmount < fuelNeeded)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.FuelAmount -= fuelNeeded;
                car.TravelledDistance += amountKM;
            }
        }
    }
}
