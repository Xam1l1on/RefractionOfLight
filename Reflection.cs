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
        public double AngleOfReflection(double angleOfInc) // Метод выводит значение угла отражения равный углу падения.
        {
            double angleOfReflection = angleOfInc;
            return angleOfReflection;
        }
        public float ReflectionXRay(double angleOfInc) // Метод выводит положение линии в "x" координатах. 
        {
            float xReflection = centerX + centerX * (float)Math.Sin(AngleOfReflection(angleOfInc));
            return xReflection;
        }
        public float ReflectionYRay(double angleOfInc) // Метод выводит положение линии в "y" координатах.
        {
            float yRefraction = centerY - centerY * (float)Math.Cos(AngleOfReflection(angleOfInc));
            return yRefraction;
        }
    }
}
