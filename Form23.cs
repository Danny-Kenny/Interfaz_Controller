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
    public partial class Form23: Form
    {
        public Form23()
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
            double Años = double.Parse(textBox3.Text);

            for (i = 1; i <= Años; i++)
            {
                double Cantidad = double.Parse(textBox1.Text);
                double Interes = double.Parse(textBox2.Text);


                double Inte_Dec = Interes / 100;
                double Gancias = ((Cantidad * Inte_Dec) * i);
                double Monto_F = Cantidad + Gancias;
                listBox1.Items.Add("Año " + i + " Monto Total " + Monto_F);
                Cantidad = Monto_F;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
