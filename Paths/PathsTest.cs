using Point;
using System;
using System.Collections.Generic;

namespace Paths
{
    class PathsTest
    {
        static void Main()
        {
            List<Point3D> points = new List<Point3D>();
            points.Add(new Point3D(-7, -4, 3));
            points.Add(new Point3D(17, 6, 2.5));
            points.Add(new Point3D(-5, -3.25, 3));
            points.Add(new Point3D(1.7, 6.5, 2.5));
            Path3D path = new Path3D(points);
            Console.WriteLine("Writed:{0}{1}", Environment.NewLine, path);
            Storage.SavePathToFile("..\\..\\paths.txt", path);
            Path3D pathFromFile = Storage.ReadPathFromFile("..\\..\\paths.txt");
            Console.WriteLine("Readed:{0}{1}",Environment.NewLine,pathFromFile);
        }
    }
}
