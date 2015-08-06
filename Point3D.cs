using System;
using System.Text;
using Point3D;

namespace Point3D.Data
{
    public class Point3D
    {
        private int cordinateX;
        private int cordinateY;
        private int cordinateZ;
        private static readonly Point3D startingPoint ;

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
        
        public static Point3D StartingPoint
        {
            get
            {
                return new Point3D(0,0,0);
            }
        }

        public override string ToString()
        {
            StringBuilder point = new StringBuilder();
            point.AppendFormat("X: {0} \nY: {1} \nZ: {2}",this.cordinateX,this.cordinateY,this.cordinateZ);
            return point.ToString();
        }

    }
}
