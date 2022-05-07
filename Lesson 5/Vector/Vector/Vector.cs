using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        private double fx, fy, fz;
        public Vector (double ax, double ay, double az)
        {
            fx = ax;
            fy = ay;
            fz = az;
        }
        public double x
        {
            get
            {
                return fx;
            }
            set
            {
                fx = value;
            }
        }
        public double y
        {
            get
            {
                return fy;
            }
            set
            {
                fy = value;
            }
        }
        public double z
        {
            get
            {
                return fz;
            }
            set
            {
                fz = value;
            }
        }
        public void Length(Vector v1)
        {
            double s = Math.Sqrt(v1.x * v1.x + v1.y * v1.y + v1.z * v1.z);
            Console.WriteLine("Result Length Of Vector = {0}", s);
        }
        public void ScalarProduct(Vector v1, Vector v2)
        {
            double s = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            Console.WriteLine("Result Scalar Product = {0}", s);
        }
        public void VectorProduct(Vector v1, Vector v2)
        {
            double xp = v1.y * v2.z - v2.y * v1.z;
            double yp = v2.x * v1.z - v1.x * v2.z;
            double zp = v1.x * v2.y - v2.x * v1.y;            
            Console.WriteLine("Result Product of Vectors: Vp[{0}, {1}, {2}]", xp, yp, zp);
        }
        public void Angle(Vector v1, Vector v2)
        {
            double s = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            double l1 = Math.Sqrt(v1.x * v1.x + v1.y * v1.y + v1.z * v1.z);
            double l2 = Math.Sqrt(v2.x * v2.x + v2.y * v2.y + v2.z * v2.z);
            double alfa = Math.Acos(s / (l1 * l2)) * 180 / Math.PI; //перевод из радиан в градусы
            Console.WriteLine("Result 'Angle between Vectors': {0}", alfa);
        }
        public void AddSub(Vector v1, Vector v2)
        {
            double[] vadd = new double[] { v1.x + v2.x, v1.y + v2.y, v1.z + v2.z};
            Console.WriteLine("Result Addition Of Vectors: V[{0}, {1}, {2}]", vadd[0], vadd[1], vadd[2]);
            double[] vsub = new double[] { v1.x - v2.x, v1.y - v2.y, v1.z - v2.z };
            Console.WriteLine("Result Subtraction Of Vectors: V[{0}, {1}, {2}]", vsub[0], vsub[1], vsub[2]);
        }
    }
}
