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
        int centerX = 350;
        int centerY = 250;

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
        public float RefractionXRay(double oneMedia, double twoMedia, double angleOfInc)
        {
            float xRefraction = centerX + centerX * (float)Math.Sin(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return xRefraction; 
        }
        public float RefractionYRay(double oneMedia, double twoMedia, double angleOfInc)
        {
            float yRefraction = centerY + centerY * (float)Math.Cos(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return yRefraction;
        }
    }
}
