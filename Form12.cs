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
    public partial class Form12: Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ahorros = double.Parse(textBox1.Text);
            double Gastos = double.Parse(textBox2.Text);

            if (Ahorros > Gastos)
            {
                Ahorros -= Gastos;
                Gastos = 0;

                textBox3.Text = Ahorros.ToString();
                textBox4.Text = Gastos.ToString();
                textBox5.Text = "Solvente".ToString();
            }
            else
            {
                Gastos -= Ahorros;
                Ahorros = 0;

                textBox3.Text = Ahorros.ToString();
                textBox4.Text = Gastos.ToString();
                textBox5.Text = "Quiebra".ToString();
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
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 From_Menu = new Form18();
            From_Menu.Show();
            this.Hide();
        }
    }
}
