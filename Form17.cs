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
    public partial class Form17: Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (textBox1.Text != "")
            { 
                do
                {
                    listBox1.Items.Add(i);
                    i++;
                } while (i <= 1000);
            }
            else
            {
                double Divi = double.Parse(textBox1.Text);
                double Divisor = double.Parse(textBox2.Text);

                do
                {
                    double S = Divi / i;
                    listBox1.Items.Add(Divi + " / " + i + " = " + S);
                    i++;
                } while (i <= Divisor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
