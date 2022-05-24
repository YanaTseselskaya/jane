using System;

namespace Figures3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box(15);
            box.Volume();            
            var cylinder = new Cylinder(10, 5);
            cylinder.Volume();
            box.Add(cylinder);
            var pyramid = new Pyramid(3, 4, 6);
            pyramid.Volume();
            box.Add(pyramid);
            var ball = new Ball(7, 4);
            ball.Volume();
            box.Add(ball);
            box.InfoAbourItems();
        }
    }
}
