using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pounds = Int32.Parse(textBox1.Text);
            int inches = Int32.Parse(textBox2.Text);
            double BMI = (pounds * 0.453592) / Math.Pow((inches * 0.0254), 2);

            label3.Text = "BMI: " + BMI.ToString();

            if (BMI < 18.5)
            {
                label4.Text = "Status: underweight";
            }
            else if(BMI > 25)
            {
                label4.Text = "Status: overweight";
            }
            else
            {
                label4.Text = "Status: average weight";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
