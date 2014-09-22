using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    static class DistanceCalc
    {
        public static double CalcDistancs(Point3D A, Point3D B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X , 2.0) + Math.Pow(A.Y - B.Y , 2.0) + Math.Pow(A.Z - B.Z , 2.0));
        }
    }
}
