﻿namespace _03._Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Height 
        {
            get
            {
                return height;
            } 
            private set
            {
                height = value;
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
                width = value;
            }
        }
        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (height + width);
        }
        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
