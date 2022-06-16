namespace _03._Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(1.25);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
            Shape rectangle = new Rectangle(1.43, 5.67);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}