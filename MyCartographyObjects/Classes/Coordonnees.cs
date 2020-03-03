using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class Coordonnees : CartoObj
    {
        #region VARIABLEMEMBRES
        private double _longitude;
        private double _latitude;
        #endregion

        #region MODIFACC
        public double longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }


        public double latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Coordonnees(double _longitude, double _latitude)
        {
            longitude = _longitude;
            latitude = _latitude;
        }
        public Coordonnees() : this(0, 0)
        {

        }
        #endregion

        #region METHODS

        public override string ToString()
        {
            return ("ID: " + id + " (" + longitude.ToString() + "," + latitude.ToString() + "),");
        }

        public override bool IsPointClose(double X, double Y, double preci)
        {
            //Pour gerer un point (pythagore)
            double Xdistance = longitude - X;
            double Ydistance = latitude - Y;
            double RealDistance = Math.Pow((Math.Pow(Xdistance, 2) + Math.Pow(Ydistance, 2)), 1d / 2d);

            return (RealDistance < preci);

        }

        public override int PointCount()
        {
            return 1;
        }
        #endregion

    }
}
