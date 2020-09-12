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
        double angleOfIncidence = 0;
        int centerX = 350;
        int centerY = 250;
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
        Refraction refract = new Refraction();
        Reflection reflect = new Reflection();

        private void RefractionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen drawNormal = new Pen(Color.Gray, 2.00f);
            Pen drawInterface = new Pen(Color.DarkGray, 3.00f);

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.DrawLine(drawNormal, centerX, 0, centerX, 500);
            g.DrawLine(drawInterface, 0, centerY, 700, centerY);
            var x = centerX - centerX * (float)Math.Sin(angleOfIncidence);
            var y = centerY - centerY * (float)Math.Cos(angleOfIncidence);
            var xRefraction = 1.00f;
            var yRefraction = 1.00f;
            var xReflection = 1.00f;
            var yReflection = 1.00f;

            g.DrawLine(Pens.Blue, centerX, centerY, x, y);
            g.DrawLine(Pens.LightGray, 0, centerY, 700, centerY);

            if (radioButton_MediaOneAir.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(air, air, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(air, glass, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(air, water, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(air, oil, angleOfIncidence) * 180) / Math.PI);
                }
            }
            else if (radioButton_MediaOneGlass.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(glass, air, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(glass, glass, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(glass, water, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(glass, oil, angleOfIncidence) * 180) / Math.PI);
                }
            }
            else if (radioButton_MediaOneWater.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(water, air, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(water, glass, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(water, water, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(water, oil, angleOfIncidence) * 180) / Math.PI);
                }
            }
            else if (radioButton_MediaOneOil.Checked == true)
            {
                if (radioButton_MediaTwoAir.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(oil, air, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoGlass.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(oil, glass, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoWater.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(oil, water, angleOfIncidence) * 180) / Math.PI);
                }
                else if (radioButton_MediaTwoOil.Checked == true)
                {
                    xRefraction = refract.RefractionXRay(air, air, angleOfIncidence);
                    yRefraction = refract.RefractionYRay(air, air, angleOfIncidence);
                    xReflection = centerX + centerX * (float)Math.Sin(reflect.AngleOfReflection(angleOfIncidence));
                    yReflection = centerY - centerY * (float)Math.Cos(reflect.AngleOfReflection(angleOfIncidence));
                    textBox_AngleOfRefraction.Text = Convert.ToString((refract.AngleOfRefraction(oil, oil, angleOfIncidence) * 180) / Math.PI);
                }
            }
            g.DrawLine(Pens.Green, centerX, centerY, xRefraction, yRefraction);
            g.DrawLine(Pens.LightSteelBlue, centerX, centerY, xReflection, yReflection);
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
