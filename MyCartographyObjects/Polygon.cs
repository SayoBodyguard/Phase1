using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MyCartographyObjects
{
    public class Polygon : CartoObj
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
            string result = base.ToString() + "Opacity: " + Opacity + "  Main Color: " + MainColor + "  Second Color: " + SecondColor;
            result += " \nCoordonées: ";
            foreach(Coordonnees c in CoordList)
                result += "\n\t[" + c.ToString() + "], ";
            return result;
        }
        public void Add(Coordonnees c) => CoordList.Add(c);
        public bool Remove(Coordonnees c) => CoordList.Remove(c);
        public override void Draw() => Console.WriteLine(ToString());


        
        

        #endregion

    }
}
