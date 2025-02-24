using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Controller
{
    public partial class Form9: Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1 = double.Parse(textBox1.Text);
            double N2 = double.Parse(textBox2.Text);
            double N3 = double.Parse(textBox3.Text);
            double N4 = double.Parse(textBox4.Text);
            double N5 = double.Parse(textBox5.Text);

            double Promedio = (N1 + N2 + N3 + N4 + N5) / 5;

            if (Promedio >= 6)
            {
                textBox6.Text = "Aprobado".ToString();
            }
            else
            {
                textBox6.Text = "Reprobado".ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
