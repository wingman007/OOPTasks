using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class SurfaceCalculator
    {
        public GeometricShape? GeometricShape { get; set; }

        public SurfaceCalculator()
        {

        }
        public SurfaceCalculator(GeometricShape geometricShape)
        {
            GeometricShape = geometricShape;
        }

        public string getInfo()
        {
            if (GeometricShape == null)
            {
                return "There is no Geometric Shape in the calculator";
            }
            else
            {
                return GeometricShape.ToString();
            }
        }

        public double getSurface()
        {
            if (GeometricShape == null)
            {
                return 0.0;
            }
            else
            {
                return GeometricShape.CalculateSurface();
            }
        }
    }
}
