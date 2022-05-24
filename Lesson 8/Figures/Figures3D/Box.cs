using System;
using System.Collections.Generic;

namespace Figures3D
{
    public class Box : Shape
    {
        private readonly double _h, _mv; 
        private double _currentVolume;
        private readonly List<Shape> _shapes;
        public Box(double heigth)
        {
            _h = heigth;
            _mv = Volume();
            _currentVolume = 0;
            _shapes = new List<Shape>();
        }        
        public double H => _h; 
        public double MaxV => _mv;       
        public override double Volume() => Math.Pow(H, 3);
        public override string ToString() => $"Куб объемом {Volume()}";        
        public void Add(Shape shape)
        {            
            var newShape = shape.Volume();            
            if ((_currentVolume == MaxV) || (newShape + _currentVolume > MaxV))//модульный тест
                throw new Exception("Ошибка! Нет места!");
            _shapes.Add(shape);            
            _currentVolume += newShape;
        }
        public void InfoAbourItems()
        {
            foreach  (var shape in _shapes) 
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
