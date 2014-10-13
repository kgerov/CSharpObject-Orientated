using System;

namespace _01.Shapes
{
    // There is a mistake in this problem. It is said that BasicShape should have properties 'width' and 'height', and that Triangle should inherit those properties.
    // However, we can't calculate the perimeter of a triangle only with one side and height.
    // I tried to do the best with the situation but overall this is not a good OOP.

    public class Triangle : BasicShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC, double height)
            : base(sideC, height)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.sideC = this.Width;

            if (this.sideA + this.sideB < sideC || this.sideA + this.sideC < sideB || this.sideC + this.sideB < sideA)
            {
                throw new ArgumentException("Invalid Triangle");
            }
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side must be a positive number");
                }

                this.sideA = value;
            }
        }

        public double SideB
        {
            get { return this.sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side must be a positive integer");
                }

                this.sideB = value;
            }
        }

        public override double CalculateArea()
        {
            return this.sideC * this.Height / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.SideA + this.SideB + this.sideC;
        }
    }
}
