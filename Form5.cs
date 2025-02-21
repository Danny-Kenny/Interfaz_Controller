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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            int C = int.Parse(textBox3.Text);

            double Raiz = Math.Sqrt((Math.Pow(B,2))-((4*A)*C));
            if (Raiz >= 0)
            {
                double X1 = (-B + Raiz) / (2 * A);
                double X2 = (-B - Raiz) / (2 * A);

                textBox4.Text = X1.ToString();
                textBox5.Text = X2.ToString();
            }
            else
            {
                textBox4.Text = "No es posible";
                textBox5.Text = "No es posible";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
