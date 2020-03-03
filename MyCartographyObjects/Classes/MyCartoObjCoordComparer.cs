using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class MyCartoObjCoordComparer : IComparer<CartoObj>
    {
        public int Compare(CartoObj x, CartoObj y)
        {
            if (x.PointCount() < y.PointCount())
                return -1;
            else
            {
                if (x.PointCount() == y.PointCount())
                    return 0;
                else
                    return 1;
            }

           
        }
    }
}
