using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefractionOfLight
{
    public partial class WorkForm : Form
    {
        Refraction refract = new Refraction();
        Reflection reflect = new Reflection();
        double angleOfIncidence = 0;
        private double air = 1.00;
        private double glass = 1.61;
        private double water = 1.33;
        private double oil = 1.47;
        public WorkForm()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RefractionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen drawNormal = new Pen(Color.Gray, 2.00f); // отрисовка линии Нормали
            Pen drawInterface = new Pen(Color.DarkGray, 3.00f); // отрисовка линии границы двух сред

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawLine(drawNormal, refract.CenterX, 0, refract.CenterX, 500);
            g.DrawLine(drawInterface, 0, refract.CenterY, 700, refract.CenterY);
            var x = refract.CenterX - refract.CenterX * (float)Math.Sin(angleOfIncidence);
            var y = refract.CenterY - refract.CenterY * (float)Math.Cos(angleOfIncidence);
            var xRefraction = 1.00f;
            var yRefraction = 1.00f;
            var xReflection = 1.00f;
            var yReflection = 1.00f;

            g.DrawLine(Pens.Blue, refract.CenterX, refract.CenterY, x, y);
            g.DrawLine(Pens.LightGray, 0, refract.CenterY, 700, refract.CenterY);
            if (radioButton_MediaOneAir.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(air, air, angleOfIncidence);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, glass, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, glass, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(air, glass, angleOfIncidence);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, water, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, water, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(air, water, angleOfIncidence);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, oil, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, oil, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(air, oil, angleOfIncidence);
                }
            }
            else if (radioButton_MediaOneGlass.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(glass, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(glass, air, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(glass, air, angleOfIncidence);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(glass, glass, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(glass, glass, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(glass, glass, angleOfIncidence);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(glass, water, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(glass, water, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(glass, water, angleOfIncidence);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(glass, oil, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(glass, oil, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(glass, oil, angleOfIncidence);
                }
            }
            else if (radioButton_MediaOneWater.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(water, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(water, air, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(water, air, angleOfIncidence);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(water, glass, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(water, glass, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(water, glass, angleOfIncidence);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(water, water, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(water, water, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(water, water, angleOfIncidence);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(water, oil, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(water, oil, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(water, oil, angleOfIncidence);
                }
            }
            else if (radioButton_MediaOneOil.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(oil, oil, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(oil, oil, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(oil, oil, angleOfIncidence);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(oil, glass, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(oil, glass, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(oil, glass, angleOfIncidence);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(oil, water, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(oil, water, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(oil, water, angleOfIncidence);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(oil, oil, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(oil, oil, angleOfIncidence);
                    xReflection = reflect.ReflectionXRay(angleOfIncidence);
                    yReflection = reflect.ReflectionYRay(angleOfIncidence);
                    textBox_AngleOfRefraction.Text = refract.ConvertAngleOfRefraction(oil, oil, angleOfIncidence);
                }
            }
            g.DrawLine(Pens.Green, refract.CenterX, refract.CenterY, xRefraction, yRefraction);
            g.DrawLine(Pens.LightSteelBlue, refract.CenterX, refract.CenterY, xReflection, yReflection);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            angleOfIncidence = Convert.ToDouble(trackBar1.Value) * Math.PI / 180.0;
            //Связь numericUpDown_SinAlpha_ValueChanged с trackBar1_Scroll
            TrackBar tbar = (TrackBar)sender;
            string numUpDnName = tbar.Name.Replace("Trackbar", "Numeric");
            foreach (Control numupdn in Controls)
            {
                if (numupdn.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)numupdn).Value = tbar.Value;
                }
            }
            panel1.Invalidate();
        }

        private void numericUpDown_SinAlpha_ValueChanged(object sender, EventArgs e)
        {
            angleOfIncidence = Convert.ToDouble(numericUpDown_SinAlpha.Value) * Math.PI / 180.0;
            //Связь numericUpDown_SinAlpha_ValueChanged с trackBar1_Scroll
            NumericUpDown numUpDn = (NumericUpDown)sender;
            string tBarName = numUpDn.Name.Replace("Numeric", "Trackbar");
            foreach (Control tbar in Controls)
            {
                if (tbar.GetType() == typeof(TrackBar))
                {
                    ((TrackBar)tbar).Value = Convert.ToInt32(numericUpDown_SinAlpha.Value);
                }
            }
            //Прорисовка отрезка преломления на panel1

            panel1.Invalidate();
        }
    }
}
