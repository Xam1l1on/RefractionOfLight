using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractionOfLight
{
    //public delegate float XYRefraction
    class Refraction
    {
        public double AOfRefr { get; set; }
        public double IOfRefr { get; set; }
        public int CenterX { get; set; } = 350;
        public int CenterY { get; set; } = 250;

        public double AngleOfRefraction(double oneMedia, double twoMedia, double angleOfInc)
        {
            IOfRefr = oneMedia / twoMedia;
            if (oneMedia == twoMedia)
            {
                AOfRefr = angleOfInc;
            }
            else if (oneMedia < twoMedia)
            {
                AOfRefr = Math.Sin(angleOfInc) * IOfRefr;
            }
            else if (oneMedia > twoMedia)
            {
                double totalIncides = twoMedia / oneMedia;
                if (angleOfInc > Math.Asin(totalIncides))
                {
                    AOfRefr = 0;
                }
                else
                    AOfRefr = Math.Sin(angleOfInc) * IOfRefr;
            }
            return AOfRefr;
        }
        public string ConvertAngleOfRefraction(double oneMedia, double twoMedia, double angleOfInc)
        {
            string convertAngleOfRefraction = Convert.ToString(AngleOfRefraction(oneMedia, twoMedia, angleOfInc) * 180 / Math.PI);
            return convertAngleOfRefraction;
        }
        public float RefractionXRay(double oneMedia, double twoMedia, double angleOfInc)
        {
            float xRefraction = CenterX + CenterX * (float)Math.Sin(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return xRefraction; 
        }
        public float RefractionYRay(double oneMedia, double twoMedia, double angleOfInc)
        {
            float yRefraction = CenterY + CenterY * (float)Math.Cos(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return yRefraction;
        }
    }
}
