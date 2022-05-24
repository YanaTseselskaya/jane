using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygon
    {
        private readonly List<Point> _points;

        public Polygon(List<Point> points)
        {
           _points = points;
            if (_points.Count < 3)
                throw new ArgumentException("Ошибка! Для построения фигуры нужны минимум 3 точки");
        }
        public Polygon(params Point[] points)
        {
            _points.AddRange(points);            
        }
        public double Perimeter(params Point[] points)
        {
            double sum = 0;            
            for (int i = 0; i < points.Length; i++)
            {
                int j = (i + 1) % points.Length;
                double x = points[j].X - points[i].X;
                double y = points[j].Y - points[i].Y;               
                sum += Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }                 
            Console.WriteLine("Perimeter of the Figure: {0}", sum);
            return sum;
        }        
    }
}