namespace _01._Vehicles
{
    public class Truck
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.6;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
    }
}
