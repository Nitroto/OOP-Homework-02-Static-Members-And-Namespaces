using System;

namespace Point
{
    class TestPoint3D
    {
        static void Main()
        {
            Point3D point1 = new Point3D(1, 1, 1);
            Point3D point2 = new Point3D(12.5,13,1);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
