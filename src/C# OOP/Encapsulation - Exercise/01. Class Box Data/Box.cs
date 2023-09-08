namespace _01._Class_Box_Data
{
    using System;
    using System.Text;

    public class Box
    {
        private const string ExceptionMessage = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                ValidateInput(value, "Length");
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                ValidateInput(value, "Width");
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                ValidateInput(value, "Height");
                height = value;
            }
        }
        public double CalculateSurfaceArea() => 2 * Length * Width + CalculateLateralSurfaceArea();

        public double CalculateLateralSurfaceArea() => 2 * (Length * Height + Width * Height);
        public double CalculateVolume() => Length * Width * Height;
        public void ValidateInput(double side, string param)
        {
            if (side <= 0)
            {
                throw new ArgumentException(string.Format(ExceptionMessage, param));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {CalculateSurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {CalculateLateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {CalculateVolume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
