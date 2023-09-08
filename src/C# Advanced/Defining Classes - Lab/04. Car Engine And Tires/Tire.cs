namespace _04._Car_Engine_And_Tires
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year { get; set; }
        public double Pressure { get; set; }
    }
}
