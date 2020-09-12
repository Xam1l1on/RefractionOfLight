using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractionOfLight
{
    class Refraction
    {
        private double angleOfRefraction;
        private double indicesOfRefraction;

        public double AngleOfRefraction(double oneMedia, double twoMedia, double angleOfInc)
        {
            indicesOfRefraction = oneMedia / twoMedia;
            if (oneMedia == twoMedia)
            {
                angleOfRefraction = angleOfInc;
            }
            else if (oneMedia < twoMedia)
            {
                angleOfRefraction = Math.Sin(angleOfInc) * indicesOfRefraction;
            }
            else if (oneMedia > twoMedia)
            {
                double totalIncides = twoMedia / oneMedia;
                if (angleOfInc > Math.Asin(totalIncides))
                {
                    angleOfRefraction = 0;
                }
                else
                    angleOfRefraction = Math.Sin(angleOfInc) * indicesOfRefraction;
            }
            return angleOfRefraction;
        }
    }
}
