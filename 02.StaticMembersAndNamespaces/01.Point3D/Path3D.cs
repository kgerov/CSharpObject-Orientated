using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path)
        {
            this.path = path;
        }

        public Path3D() { }

        public List<Point3D> Path
        {
            get { return this.path; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Invalid List of Points");
                }
                this.path = value;
            }
        }

        public void AddPoint(Point3D newP)
        {
            this.path.Add(newP);
        }

        public override string ToString()
        {
            if (this.path.Count == 0)
            {
                return "Empty Path";
            }
            string result = "Points in Path: ";
            foreach (var point in this.path)
            {
                result += "\n" + point;
            }
            return result;
        }
    }
}
