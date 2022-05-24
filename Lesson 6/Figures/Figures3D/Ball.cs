using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures3D
{
    class Ball : Shape
    {
        private readonly double _r, _h;
        public Ball(int radius, int heigth)
        {
            _r = radius;
            _h = heigth;
        }
        public double R => _r;
        public double H => _h;
        public override double Volume() => 4 * Math.PI * Math.Pow(R, 3) / 3;
        public override string ToString() => $"Шар объемом {Volume()}";
    }
}
