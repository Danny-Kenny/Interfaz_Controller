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
    public partial class Form20: Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int Edad = int.Parse(textBox1.Text);
            
            for (i = 0; i <= Edad; i++)
            {
                int Años = 2025 - i;
                listBox1.Items.Add(Años);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 Menu = new Form18();
            Menu.Show();
            this.Hide();
        }
    }
}
