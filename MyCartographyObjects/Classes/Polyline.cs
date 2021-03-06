﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MyCartographyObjects
{
    public class Polyline : CartoObj, IPointy, IComparable<Polyline>, IEquatable<Polyline>
    {
        #region MEMBERS
        private List<Coordonnees> _coordList;
        private Color _color;
        private int _thickness;
        #endregion

        #region MODIFACC
        public List<Coordonnees> CoordList
        {
            get { return _coordList; }
            set { _coordList = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Thickness
        {
            get { return _thickness; }
            set { _thickness = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Polyline(List<Coordonnees> _cList, Color colors, int thickness) :
            base()
        {
            CoordList = _cList;
            Color = colors;
            Thickness = thickness;
        }
        public Polyline(Color colors, int thickness) :
            this(new List<Coordonnees>(), colors, thickness)
        { }
        public Polyline() :
            this(Colors.White, 5)
        { }

        #endregion

        #region METHODS
        public override string ToString()
        {
            string result = "ID: " + base.ToString() + "  Color: " + Color.ToString() + "  Thickness: " + Thickness + "  \nCoordonnées: ";

            foreach (Coordonnees C in CoordList)
            {
                result += "\n\t[" + C.ToString();
                result += "]";
            }
            return result;
        }
        public override void Draw()
        {
            Console.WriteLine(ToString());
        }
        public void Add(Coordonnees param)
        {
            if (param != null)
                CoordList.Add(param);
        }

        public override bool IsPointClose(double X, double Y, double preci)
        {
            foreach (Coordonnees c in CoordList)
            {
                //Pour gerer un point (pythagore)
                double Xdistance = c.longitude - X;
                double Ydistance = c.latitude - Y;
                double RealDistance = Math.Pow((Math.Pow(Xdistance, 2) + Math.Pow(Ydistance, 2)), 1d / 2d);

                if (RealDistance < preci)
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
                if (temp.Contains(c))
                    result++;
                temp.Add(c);
            }
            return result;
        }

        public double length()
        {
            double result = 0;
            for (int i = 0; i < CoordList.Count() - 1; i++)
            {
                result += Math.Sqrt((Math.Pow(CoordList[i].latitude, 2) + Math.Pow(CoordList[i + 1].latitude, 2)));
            }
            return result;
        }

        public int CompareTo(Polyline other)
        {
            if (this.length() < other.length())
                return -1;
            else
            {
                if (this.length() == other.length())
                    return 0;
                else
                    return 1;
            }

        }

        public bool Equals(Polyline other)
        {
            if (Thickness == other.Thickness)
            {
                if(CoordList.Count == other.CoordList.Count)
                {
                    for(int i = 0; i < CoordList.Count; i++)
                    {
                        if(!(CoordList[i].Equals( other.CoordList[i]))) { return false; }
                    }
                    return true;
                }
            }
            return false;
        }

        public override int PointCount()
        {
            return CoordList.Count();
        }


        #endregion
    }
}
