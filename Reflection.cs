using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractionOfLight
{
    class Reflection
    {
        int centerX = 350;
        int centerY = 250;
        public double AngleOfReflection(double angleOfInc)
        {
            double angleOfReflection = angleOfInc;
            return angleOfReflection;
        }
        public float ReflectionXRay(double angleOfInc)
        {
            float xReflection = centerX + centerX * (float)Math.Sin(AngleOfReflection(angleOfInc));
            return xReflection;
        }
        public float ReflectionYRay(double angleOfInc)
        {
            float yRefraction = centerY + centerY * (float)Math.Cos(AngleOfReflection(angleOfInc));
            return yRefraction;
        }
    }
}
