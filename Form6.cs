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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);

            double Distancia = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));

            textBox5.Text = Distancia.ToString();
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
            Form18 Form_Menu = new Form18();
            Form_Menu.Show();
            this.Hide();
        }
    }
}
