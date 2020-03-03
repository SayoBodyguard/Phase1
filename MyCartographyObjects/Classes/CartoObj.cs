using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public abstract class CartoObj : IIsPointClose
    {
        #region MEMBERS
        private static int _previousID = 0;
        private int _id;
        #endregion

        #region MODIFACC
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public CartoObj()
        {
            id = _previousID++;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return id.ToString();
        }

        public virtual void Draw()
        {
            Console.WriteLine(ToString());
        }

        public abstract int PointCount();

        public abstract bool IsPointClose(double X, double Y, double preci);
        #endregion

    }
}