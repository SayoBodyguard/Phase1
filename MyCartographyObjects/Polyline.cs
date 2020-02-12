﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MyCartographyObjects
{
    public class Polyline : CartoObj
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
            string result = "ID: "+ base.ToString() + "  Color: "+ Color.ToString() + "  Thickness: " + Thickness + "  \nCoordonnées: ";

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
            if (param!= null)
                CoordList.Add(param);
        }
        #endregion
    }
}