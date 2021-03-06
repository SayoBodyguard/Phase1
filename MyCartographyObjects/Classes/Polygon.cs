﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MyCartographyObjects
{
    public class Polygon : CartoObj, IPointy
    {
        #region MEMBERS
        private List<Coordonnees> _clist;
        private Color _maincolor;
        private Color _secondcolor;
        private double _opacity;
        #endregion

        #region MODIFACC
        public double Opacity
        {
            get { return _opacity; }
            set { _opacity = value; }
        }


        public Color SecondColor
        {
            get { return _secondcolor; }
            set { _secondcolor = value; }
        }


        public Color MainColor
        {
            get { return _maincolor; }
            set { _maincolor = value; }
        }


        public List<Coordonnees> CoordList
        {
            get { return _clist; }
            set { _clist = value; }
        }





        #endregion

        #region CONSTRUCTORS
        public Polygon(double opacity, Color secondColor, Color mainColor, List<Coordonnees> coordList) : base()
        {
            Opacity = opacity;
            SecondColor = secondColor;
            MainColor = mainColor;
            CoordList = coordList ?? throw new ArgumentNullException(nameof(coordList));
        }
        public Polygon() : this(1, Colors.White, Colors.Black, new List<Coordonnees>())
        { }
        #endregion

        #region METHODS
        public override string ToString()
        {
            string result = "ID: " + base.ToString() + " Opacity: " + Opacity + "  Main Color: " + MainColor + "  Second Color: " + SecondColor;
            result += " \nCoordonées: ";
            foreach(Coordonnees c in CoordList)
                result += "\n\t[" + c.ToString() + "], ";
            return result;
        }
        public void Add(Coordonnees c) => CoordList.Add(c);
        public bool Remove(Coordonnees c) => CoordList.Remove(c);
        public override void Draw() => Console.WriteLine(ToString());

        public override bool IsPointClose(double X, double Y, double preci)
        {
            double maxX;
            double   maxY = maxX = -1000000000;
            //finding max coordonates
            foreach(Coordonnees c in CoordList)
            {
                if (c.longitude > maxX)
                    maxX = c.longitude;
                if (c.latitude > maxY)
                    maxY = c.latitude;
            }
            if(maxX > X)
            {
                if (maxY > Y)
                    return true;
            }
            return false;
        }

        public int PointAmount()
        {
            int result = 0;
            List<Coordonnees> temp = new List<Coordonnees>();
            foreach (Coordonnees c in CoordList)
            {
                if (!temp.Contains(c))
                    result++;
                temp.Add(c);
            }
            return result;
        }

        public override int PointCount()
        {
            return CoordList.Count();
        }


        #endregion

    }
}
