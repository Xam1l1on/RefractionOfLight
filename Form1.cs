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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Кнопка перехода на форму "WorkForm"
        {
            WorkForm wForm = new WorkForm();
            this.Hide();
            wForm.Show();
        }
        private void AboutRefOfLightButton_Click(object sender, EventArgs e) //Кнопка вызова справки о явлении преломления и явлении отражения 
        {
            System.Diagnostics.Process.Start("https://online.mephi.ru/courses/physics/optics/data/course/3/3.2.html");
        }
        private void Exitbutton_Click(object sender, EventArgs e) //Кнопка выхода из прошраммы.
        {
            Application.Exit();
        }
    }
}
