using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class MyPolylineBoundingBoxComparer : IComparer<Polyline>
    {
        public int Compare(Polyline x, Polyline y)
        {
            //determiner la bounding box de X et d'Y
            if (BoundingBoxSurfaceFinder(x) < BoundingBoxSurfaceFinder(y)) { return -1; }
            if (BoundingBoxSurfaceFinder(x) == BoundingBoxSurfaceFinder(y)) { return 0; }
            return 1;
        }
        private double BoundingBoxSurfaceFinder(Polyline x)
        {
            if (x.PointCount() == 0)
                return 0;
            double MaxX = x.CoordList[0].longitude;
            double MaxY = x.CoordList[0].latitude;
            double MinX = MaxX;
            double MinY = MaxY;

            for (int i = 1; i < x.CoordList.Count(); i++)
            {
                if (MaxX > x.CoordList[i].longitude) { MaxX = x.CoordList[i].longitude; }
                else
                {
                    if (MinX < x.CoordList[i].longitude) { MinX = x.CoordList[i].longitude; }
                }
                if (MaxY > x.CoordList[i].latitude) { MaxY = x.CoordList[i].latitude; }
                else
                {
                    if (MinY < x.CoordList[i].latitude) { MinX = x.CoordList[i].latitude; }
                }
            }

            return (MaxX - MinX) * (MaxY - MinY);


        }
    }
}
