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
    public partial class Form21: Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int Numero = int.Parse(textBox1.Text);

            for (i = 0; i <= Numero; i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 Menu = new Form18();
            Menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
