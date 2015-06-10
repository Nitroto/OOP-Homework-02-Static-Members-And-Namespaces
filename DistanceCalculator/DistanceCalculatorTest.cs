using Point;
using System;

namespace DistanceCalculator
{
    class DistanceCalculatorTest
    {
        static void Main()
        {
            Point3D point1 = new Point3D(-7, -4, 3);
            Point3D point2 = new Point3D(17, 6, 2.5);
            Console.WriteLine(DistanceCalculator.CalculateTheDistance(point1,point2));
            Point3D point3 = new Point3D(-5, -3.25, 3);
            Point3D point4 = new Point3D(1.7, 6.5, 2.5);
            Console.WriteLine(DistanceCalculator.CalculateTheDistance(point3, point4));
        }
    }
}
