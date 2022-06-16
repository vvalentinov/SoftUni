namespace _04._Need_for_Speed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual double FuelConsumption { get { return DefaultFuelConsumption; } }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
