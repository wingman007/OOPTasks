using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Cone : GeometricShape
    {
        public Cone(double r, double h) : base(r, h)
        {
        }

        public override double CalculateVolume()
        {
            return (1.0/3.0) * Math.PI * Math.Pow(R, 2) * H;
        }

        public override string ToString()
        {
            return String.Format($"This is a Cone with R = {R}, H = {H}");
        }
    }
}
