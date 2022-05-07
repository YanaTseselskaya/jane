using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec0 = new Vector(0, 0, 0);
            Vector vec1 = new Vector(5, 4, 6);
            Vector vec2 = new Vector(8, 12, 3);
            
            vec0.Length(vec1);
            vec0.Length(vec2);
            vec0.ScalarProduct(vec1, vec2);
            vec0.VectorProduct(vec1, vec2);
            vec0.Angle(vec1, vec2);
            vec0.AddSub(vec1, vec2);            
        }
    }
}
