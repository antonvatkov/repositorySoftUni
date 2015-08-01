using System;

namespace Point3D.Core
{
    public static class PointDistanceCalculator
    {
        public static double DistanceCalculator(Point3D.Data.Point3D pointA,Point3D.Data.Point3D pointB)
        {
            return Math.Sqrt(Math.Pow((pointB.CordinateX - pointA.CordinateX),2) + Math.Pow((pointB.CordinateY - pointA.CordinateY),2) + Math.Pow((pointB.CordinateZ - pointA.CordinateZ),2));
        }
    }
}
