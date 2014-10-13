using System;

namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be bigger than 0");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be bigger than 0");
                }

                this.height = value;
            }
        } 

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
