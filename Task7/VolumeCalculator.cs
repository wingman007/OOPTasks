using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class VolumeCalculator
    {
        public GeometricShape? GeometricShape { get; set; }

        public VolumeCalculator()
        {

        }
        public VolumeCalculator(GeometricShape geometricShape)
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

        public double getVolume()
        {
            if (GeometricShape == null)
            {
                return 0.0;
            }
            else
            {
                return GeometricShape.CalculateVolume();
            }
        }
    }
}
