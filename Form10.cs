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
    public partial class Form10: Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntuacion = int.Parse(textBox1.Text);

            if (puntuacion <= 100)
            {
                textBox2.Text = "Baja".ToString();
            }
            else
            {
                textBox2.Text = "Alta".ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
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
