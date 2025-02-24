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
    public partial class Form8: Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AN = int.Parse(textBox1.Text);
            int AA = int.Parse(textBox2.Text);

            int Edad = AA - AN;

            if (Edad >= 18)
            {
                textBox3.Text = "Mayor".ToString();
            }
            else
            {
                textBox3.Text = "Menor".ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
