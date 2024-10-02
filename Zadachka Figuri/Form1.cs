using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadachka_Figuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            if (radioButton1.Checked)
            {
                label6.Text = (4 * a).ToString();
                label7.Text = (a * a).ToString();
            }

            if (radioButton2.Checked)
            {
                label6.Text = (2 * (a + b)).ToString();
                label7.Text = (a * b).ToString();
            }

            if (radioButton3.Checked)
            {
                label6.Text = (a + b + c).ToString();
                label7.Text = ((a * b) / 2).ToString();
            }
        }
    }
}
