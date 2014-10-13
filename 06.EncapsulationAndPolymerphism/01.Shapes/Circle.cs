using System;

namespace _01.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Radius must be bigger than 0");
                }

                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            return Math.Pow(this.radius, 2.0) * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return Math.PI * 2 * this.radius;
        }
    }
}
