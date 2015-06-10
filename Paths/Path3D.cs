using Point;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paths
{
    class Path3D
    {
        private List<Point3D> path;

        public Path3D(List<Point3D> path = null)
        {
            this.Path = path;
        }

        public List<Point3D> Path
        {
            get { return this.path; }
            set
            {
                this.path = value ?? new List<Point3D>();
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (Point3D point in this.Path)
            {
                output.Append(string.Format("{0:F2} {1:F2} {2:F2}{3}", point.X, point.Y, point.Z, Environment.NewLine));
            }
            return output.ToString();
        }
    }
}
