using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shapes
{
    class Tester
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle(4.1, 3.4, 5.5, 3.2);
            Rectangle abcd = new Rectangle(5, 10);
            Circle o = new Circle(4.3);

            IShape[] figures = new IShape[3] {
                abc,
                abcd,
                o
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetType().Name + " has a perimeter: " + figure.CalculatePerimeter() + " and area: " + figure.CalculateArea());
            }
        }
    }
}
