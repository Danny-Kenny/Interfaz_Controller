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
    public partial class Form22: Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 Menu = new Form18();
            Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int Number = int.Parse(textBox1.Text);

            for (i = 0; i <= Number; i++)
            {
                int secuen = Number - i;
                listBox1.Items.Add(secuen);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
