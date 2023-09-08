namespace _03._Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                radius = value;
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * radius;
        }
        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
