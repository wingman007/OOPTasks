using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Sphere : GeometricShape
    {
        public double R { get; set; }

        public Sphere()
            :this(0.0)
        {

        }
        public Sphere(double r)
        {
            R = r;
        }
        public override double CalculateSurface()
        {
            return 4.0 * Math.PI * Math.Pow(R, 2.0);
        }

        public override string ToString()
        {
            return String.Format($"This is a Sphere with R = {R}");
        }
    }
}
