namespace _08._Car_Salesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, string weight, string color) : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }
    }
}
