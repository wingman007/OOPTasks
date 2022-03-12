using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Cylinder : GeometricShape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }

        public override string ToString()
        {
            return String.Format($"This is a Cylinder with R = {R}, H = {H}");
        }
    }
}
