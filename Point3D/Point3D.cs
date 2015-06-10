/// Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Create appropriate constructors. 
/// Override ToString() to enable printing a 3D point.
/// Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint 
/// {0, 0, 0}. Add a static property to return the starting point.

namespace Point
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.x; }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get { return this.y; }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get { return this.z; }
            set
            {
                this.z = value;
            }
        }
        public static Point3D StartingPoint
        {
            get
            {
                return startingPoint;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Point({0},{1},{2})", this.X,this.Y,this.Z);
            return output;
        }
    }
}
