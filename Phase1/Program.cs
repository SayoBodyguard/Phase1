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
            Coordonnees c2 = new Coordonnees(2d, 5d);

            POI poi1 = new POI();
            POI poi2 = new POI("Second POI", 2d, 5d);

            Polygon poly1 = new Polygon();
            Polygon poly2 = new Polygon(0.2, Colors.Red, Colors.Blue, new List<Coordonnees>());


            Polyline pol1 = new Polyline();
            Polyline pol2 = new Polyline(Colors.Red, 1);
            pol2.Add(c1);
            pol2.Add(c2);
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

            Console.WriteLine("\nForeach 1");
            foreach (CartoObj c in carList)
                c.Draw();
            Console.WriteLine("\nForeach 2");
            foreach (CartoObj c in carList)
                if (c is IPointy)
                    c.Draw();
            Console.WriteLine("\nForeach 3");
            foreach (CartoObj c in carList)
                if (!(c is IPointy))
                    c.Draw();

            Console.WriteLine("\nListe de polylines");
            List<Polyline> polylist = new List<Polyline>();
            polylist.Add(pol1);
            polylist.Add(pol2);
            polylist.Add(pol1);
            polylist.Add(pol2);
            polylist.Add(pol1);
            foreach (Polyline p in polylist)
                p.Draw();
            Console.WriteLine("\n\nApres triage...");
            polylist.Sort();
            foreach (Polyline p in polylist)
                p.Draw();
            Console.WriteLine("\n\nApres Triage 2...");

            polylist.Sort(new MyPolylineBoundingBoxComparer());
            foreach (Polyline p in polylist)
                p.Draw();

            Polyline pol3 = polylist.Find(match: x => x.Thickness.Equals(2));

            Console.WriteLine("\n\nPolylines Proches...");
            foreach (Polyline p in polylist)
            {
                if (p.IsPointClose(5, 2, 1)) { p.Draw(); }
            }
            Console.WriteLine("\n\nListe de CartoObj");
            carList.Sort(new MyCartoObjCoordComparer());
            foreach (CartoObj c in carList)
                c.Draw();






            //BLOCKING 
            Console.ReadKey();
        }
    }
}
