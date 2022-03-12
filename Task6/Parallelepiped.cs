using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Parallelepiped : GeometricShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Parallelepiped()
            :this(0.0, 0.0, 0.0)
        {

        }
        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double CalculateSurface()
        {
            return 2 * (A * B + A * C + B * C);
        }

        public override string ToString()
        {
            return String.Format($"This is a Parallelepiped with A = {A}, B = {B}, C = {C}");
        }
    }
}
