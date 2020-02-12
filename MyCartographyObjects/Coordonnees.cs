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
            return ("(" + longitude.ToString() + "," + latitude.ToString() + ")," + " ID: " + id);
        }
        #endregion

    }
}
