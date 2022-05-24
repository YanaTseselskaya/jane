using System;

namespace Figures3D
{
    public class Pyramid : Shape
    {
        private readonly double _l, _n, _h;

        public Pyramid(double length, double number, double heigth)
        {
            _l = length; // length - длина стороны основания пирамиды
            _n = number; //число сторон многоугольника, лежащего в основании пирамид
            _h = heigth;
        }
        public double L => _l;
        public double N => _n;
        public double H => _h;
        public override double Volume() => Math.Pow(L,2) * N * H / 3 / 4 / Math.Tan(180 / N);//модульный тест
        // формула для вычисления площади основания: S = p * a / 2.
        // Здесь a = L / 2 / Math.Tan(180 / N) - апофема, p = L * N - периметр основания
        public override string ToString() => $"Пирамида объемом {Math.Round(Volume())}";
    }
}
