using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures3D
{
    class Cylinder : Shape
    {
        private readonly double _r, _h;
        public Cylinder(double radius, double heigth)
        {
            _r = radius;
            _h = heigth; 
        }        
        public double R => _r;
        public double H => _h;
        public override double Volume() => Math.PI * Math.Pow(R, 2) * H;
        public override string ToString() => $"Цилиндр объемом {Volume()}";       
    }
}
