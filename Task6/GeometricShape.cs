using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal abstract class GeometricShape : ISurfaceCalculate
    {
        public virtual double CalculateSurface()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "There is no specific figure (Geometric Shape) information defined.";
        }
    }
}
