using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> vertices = new List<Point>()
            {
                new Point(3, 4, "Point 1"),
                new Point(15, 0, "Point 2"),
                new Point(26, 7, "Point 3"),
                new Point(8, -9, "Point 4")
            };
            var polygon = new Polygon(vertices);
            polygon.Perimeter(vertices.ToArray());               
        }
    }
}
