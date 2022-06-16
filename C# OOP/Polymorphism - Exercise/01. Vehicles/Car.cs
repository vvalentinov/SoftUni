namespace _01._Vehicles
{
    public class Car
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 0.9;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
    }
}
