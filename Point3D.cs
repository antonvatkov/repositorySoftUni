﻿using System;

namespace Point3D.Data
{
    public class Point3D
    {
        private int cordinateX;
        private int cordinateY;
        private int cordinateZ;
        private static readonly Point3D StartingPoint ;

        public Point3D(int cordinateX, int cordinateY)
        {
            this.CordinateX = cordinateX;
            this.CordinateY = cordinateY;
        }

        public Point3D(int cordinateX, int cordinateY, int cordinateZ)
            : this(cordinateX,cordinateY)
        {
            this.CordinateZ = cordinateZ;
        }

        public int CordinateX { get; set; }
        public int CordinateY { get; set; }
        public int CordinateZ { get; set; }
        
        public static Point3D ReturnStartingPoint
        {
            get
            {
                return new Point3D(0,0,0);
            }
        }

    }
}
