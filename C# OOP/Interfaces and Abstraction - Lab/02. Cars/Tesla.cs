namespace _02._Cars
{
    using System.Text;

    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Battery { get; private set; }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.Append(Stop());
            return sb.ToString().TrimEnd();
        }
    }
}
