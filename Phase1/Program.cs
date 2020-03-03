using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace Phase1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DECLARATIONS
            Coordonnees c1 = new Coordonnees();
            Coordonnees c2 = new Coordonnees(2d,5d);

            POI poi1 = new POI();
            POI poi2 = new POI("Second POI",2d,5d);

            Polygon poly1 = new Polygon();
            Polygon poly2 = new Polygon(0.2, Colors.Red, Colors.Blue, new List<Coordonnees>());

            Polyline pol1 = new Polyline();
            Polyline pol2 = new Polyline(Colors.Red, 1);
            #endregion

            List<CartoObj> carList = new List<CartoObj>();
            carList.Add(c1);
            carList.Add(c2);
            carList.Add(poi1);
            carList.Add(poi2);
            carList.Add(poly1);
            carList.Add(poly2);
            carList.Add(pol1);
            carList.Add(pol2);

            foreach (CartoObj c in carList)
                c.Draw();

            foreach (CartoObj c in carList)
                if (c is IPointy)
                    c.Draw();



            //BLOCKING 
            Console.ReadKey();
        }
    }
}
