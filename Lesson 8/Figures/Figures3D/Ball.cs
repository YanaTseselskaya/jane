using System;

namespace Figures3D
{
    public class Ball : Shape
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
        public override string ToString() => $"Шар объемом {Math.Round(Volume())}";
    }
}
