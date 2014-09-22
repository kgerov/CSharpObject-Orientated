using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class PointTest
    {
        static void Main(string[] args)
        {
            Point3D A = new Point3D(3, 4, 5);
            Console.WriteLine(A);
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine("Distance = " + Math.Round(DistanceCalc.CalcDistancs(A, Point3D.StartingPoint), 4));
            Console.WriteLine(new String('-', 40));

            Point3D C = new Point3D(-3, 14, -5);
            Point3D D = new Point3D(-3.1, 4.4, 115);
            List<Point3D> points = new List<Point3D>()
            {
                A,
                Point3D.StartingPoint,
                C
            };

            Path3D path = new Path3D(points);
            Console.WriteLine(path);
            Console.WriteLine(new String('-', 40));
            path.AddPoint(D);
            Console.WriteLine(path);

            Storage.Save(path);
            Path3D loadedPath = Storage.Load("path.txt");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("PATH FROM LOADED FILE: ");
            Console.WriteLine(loadedPath);
        }
    }
}
