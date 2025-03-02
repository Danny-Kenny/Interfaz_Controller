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
    public partial class Form11: Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Examen = double.Parse(textBox1.Text);
            double Practicas = double.Parse(textBox2.Text);

            if (Examen >= 70 && Practicas >= 8)
            {
                textBox3.Text = "Aprobado".ToString();
            }
            else
            {
                textBox3.Text = "Reprobado".ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "".ToString();
            textBox2.Text = "".ToString();
            textBox3.Text = "".ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 From_Menu = new Form18();
            From_Menu.Show();
            this.Hide();
        }
    }
}
