using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace _01.Point3D
{
    static class Storage
    {
        public static void Save(Path3D path)
        {
            string fileName = "path.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                foreach (var point in path.Path)
                {
                    file.Write(String.Format("({0},{1},{2});", point.X, point.Y, point.Z));
                }
            }
        }

        public static Path3D Load(String fileName)
        {
            Path3D path = new Path3D();
            string text = System.IO.File.ReadAllText(fileName);
            Regex rgx = new Regex(@"\((.+?),(.+?),(.+?)\)");
            Match match = rgx.Match(text);
            while (match.Success)
            {
                Point3D cPoint = new Point3D(Double.Parse(match.Groups[1].Value), Double.Parse(match.Groups[2].Value), Double.Parse(match.Groups[3].Value));
                match = match.NextMatch();
                path.AddPoint(cPoint);
            }

            return path;
        }
    }
}
