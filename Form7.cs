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
    public partial class Form7: Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Proc1 = int.Parse(textBox1.Text);
            int Proc2 = int.Parse(textBox2.Text);
            int Proc3 = int.Parse(textBox3.Text);
            int Proc4 = int.Parse(textBox4.Text);
            int Proc5 = int.Parse(textBox5.Text);

            int T_Net = Proc1 + Proc2 + Proc3 + Proc4 + Proc5;

            if (T_Net > 2000)
            {
                double Total = T_Net - (T_Net * .10);

                textBox6.Text = T_Net.ToString();
                textBox7.Text = "10%".ToString();
                textBox8.Text = Total.ToString();
            }
            else
            {
                textBox6.Text = T_Net.ToString();
                textBox7.Text = "0%".ToString();
                textBox8.Text = T_Net.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
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
