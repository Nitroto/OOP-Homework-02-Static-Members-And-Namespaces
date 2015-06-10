using Point;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Paths
{
    static class Storage
    {
        private static Regex dataValidation = new Regex(@"^-?\d*.?\d*\s-?\d*.?\d*\s-?\d*.?\d*$");

        public static void SavePathToFile(string filePath, Path3D path)
        {
            if (Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    writer.WriteLine(path.ToString());
                }
            }
            else
            {
                throw new ArgumentException("filePath", "Invalide file path!");
            }
        }

        public static Path3D ReadPathFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Path3D path = new Path3D();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    List<Point3D> points = new List<Point3D>();
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (dataValidation.Match(line).Success)
                        {
                            double[] coordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
                            points.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                        }
                    }
                    path = new Path3D(points);
                }
                return path;
            }
            throw new ArgumentException("filePath", "File does not exist!");
        }
    }
}
