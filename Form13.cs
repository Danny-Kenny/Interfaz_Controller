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
    public partial class Form13: Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Temperatura = double.Parse(textBox1.Text);
            double Presion = double.Parse(textBox2.Text);

            if (Presion > 200 || Temperatura > 100)
            {
                textBox3.Text = "Alarma".ToString();
            }
            else
            {
                textBox3.Text = "Normal".ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
