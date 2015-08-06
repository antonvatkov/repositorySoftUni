using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Point3D.Core;
//using Point3D.Data;
//using Point3D.Point.Core.System;

namespace Point3D
{
    public class Point3DTest
    {
        static void Main()
        {
            List<Point3D.Data.Point3D> points3D = new List<Data.Point3D>();
            //Point3D.Point.Core.System. sequance = points3D;
            Point3D.Data.Point3D point222 = new Data.Point3D(1,333);
            Point3D.Data.Point3D point111 = new Data.Point3D(1, 666, 999);
            Console.WriteLine(point222.ToString() + Environment.NewLine);

            points3D.Add(point111);
            foreach (var item in points3D)
            {
                item.ToString();
                    Console.WriteLine(item);
            }
            points3D.Add(point222);
            string path = @"C:\Users\PC\Desktop\RADIO\test.txt";
            Point3D.Point.Core.System.Storage.SaveFile(points3D, path);

            Point3D.Point.Core.System.Storage.OpenFile(path);
        }
    }
}
