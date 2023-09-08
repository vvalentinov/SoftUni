namespace CarManufacturer
{
    using System;

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double consumption = FuelConsumption * distance;
            if (FuelQuantity - consumption <= 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= consumption;
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
        }
    }
}
