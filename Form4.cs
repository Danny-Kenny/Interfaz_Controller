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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            double S = (r * r) * 3.14;

            textBox2.Text = S.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
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
