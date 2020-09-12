using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractionOfLight
{
    class Refraction // Класс содержит автоматические свойсва
    {
        public double AOfRefr { get; set; } // Угол падения света — угол между падающим на поверхность лучом и нормалью к поверхности;
        public double IOfRefr { get; set; } // Угол преломления света — угол между прошедшим через поверхность лучом и нормалью к поверхности.
        public double TOfInc { get; set; } //  Полное внутреннее отражение (преломлённый луч отсутствует, падающий луч полностью отражается от границы раздела сред). 
        public int CenterX { get; set; } = 350; // Центр panel1 по ширине
        public int CenterY { get; set; } = 250; // Центра panel1 по высоте

        public double AngleOfRefraction(double oneMedia, double twoMedia, double angleOfInc) // Метод высчитвывающий угол преломления света(IOfRefr)
        {
            IOfRefr = oneMedia / twoMedia;
            if (oneMedia * twoMedia == 1)
            {
                AOfRefr = angleOfInc;
            }
            else if (oneMedia < twoMedia)
            {
                AOfRefr = Math.Sin(angleOfInc) * IOfRefr;
            }
            else if (oneMedia > twoMedia)
            {
                TOfInc = twoMedia / oneMedia;
                if (angleOfInc > Math.Asin(TOfInc))
                {
                    AOfRefr = 0;
                }
                else
                    AOfRefr = Math.Sin(angleOfInc) * IOfRefr;
            }
            return AOfRefr;
        }
        public string ConvertAngleOfRefraction(double oneMedia, double twoMedia, double angleOfInc) //Метод конвертиует из double в string значение угла преломления 
        {
            string convertAngleOfRefraction = Convert.ToString(AngleOfRefraction(oneMedia, twoMedia, angleOfInc) * 180 / Math.PI);
            return convertAngleOfRefraction;
        }
        public float RefractionXRay(double oneMedia, double twoMedia, double angleOfInc) // Метод просчитывает положение точки по ширине  
        {
            float xRefraction = CenterX + CenterX * (float)Math.Sin(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return xRefraction; 
        }
        public float RefractionYRay(double oneMedia, double twoMedia, double angleOfInc) // Метод просчитывает положение точки по высоте
        {
            float yRefraction = CenterY + CenterY * (float)Math.Cos(AngleOfRefraction(oneMedia, twoMedia, angleOfInc));
            return yRefraction;
        }
    }
}
