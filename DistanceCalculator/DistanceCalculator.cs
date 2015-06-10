using System;
using Point;

namespace DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateTheDistance(Point3D firstPoint, Point3D secondPoint)
        {
            // http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
            double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) + 
                                        (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) + 
                                        (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
            return distance;
        }
    }
}

