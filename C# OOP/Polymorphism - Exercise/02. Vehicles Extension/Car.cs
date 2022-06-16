namespace _02._Vehicles_Extension
{
    public class Car
    {
        private double tankCapacity;
        
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + 0.9;
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
