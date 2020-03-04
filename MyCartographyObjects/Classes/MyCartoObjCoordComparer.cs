using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class MyCartoObjCoordComparer : IComparer<CartoObj> 
    {
        public int Compare(CartoObj x, CartoObj y) => x.PointCount().CompareTo(y.PointCount());
    }
}
