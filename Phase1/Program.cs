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
            POI poi1 = new POI();
            Coordonnees coord = new Coordonnees(22, 4);
            Polyline poly = new Polyline(Colors.Red, 3);
            Polygon polyg = new Polygon();

            poly.Add(coord);
            poly.Add(new Coordonnees(5, 3));
            poly.Add(new Coordonnees(8, 4));
            poly.Add(poi1);

            polyg.Add(coord);
            polyg.Add(new Coordonnees(5, 3));
            polyg.Add(new Coordonnees(8, 4));
            polyg.Add(poi1);


            Console.WriteLine(poi1.ToString());
            Console.WriteLine(coord.ToString());
            Console.WriteLine(poly.ToString());
            Console.WriteLine(polyg.ToString());
            Console.ReadKey();
        }
    }
}
