using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal abstract class GeometricShape : IVolumeCalculate
    {
        public double R { get; set; }
        public double H { get; set; }
        public GeometricShape(double r, double h)
        {
            R = r;
            H = h;
        }
        public abstract double CalculateVolume();
    }
}
