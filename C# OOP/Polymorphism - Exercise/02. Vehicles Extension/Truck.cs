namespace _02._Vehicles_Extension
{
    public class Truck
    {
        private double tankCapacity;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 1.6;
            this.TankCapacity = tankCapacity;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (this.FuelQuantity > value)
                {
                    this.FuelQuantity = 0;
                }
                else
                {
                    this.tankCapacity = value;
                }
            }
        }
    }
}
