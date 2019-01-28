using System;
using Factory.CreationalFactories;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3, Point.CoordinateSystem.Cartesian);
            var origin = Point.Origin;
            var p2 = Point.Factory.NewCartesianPoint(1, 2);
        }
    }
}
