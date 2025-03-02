using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Controller
{
    public partial class Form15: Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                int S = 6 * i;
                listBox1.Items.Add("6 X " + i + " = " + S);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Multiplicador = int.Parse(textBox1.Text);
            int Multi = int.Parse(textBox2.Text);
            int i;
            for (i = 0; i <= Multi; i++)
            {
                int S = Multiplicador * i;
                listBox2.Items.Add(Multiplicador + " X " + i + " = " + S);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form18 From_Menu = new Form18();
            From_Menu.Show();
            this.Hide();
        }
    }
}
