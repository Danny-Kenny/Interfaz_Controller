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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(textBox1.Text);
            int N2 = int.Parse(textBox2.Text);

            int S = N1 + N2;

            //MessageBox.Show("El resultado es: " + S); Muestra una pantalla con el S
            textBox3.Text = S.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = ""; De forma manual
            //textBox2.Text = "";
            textBox1.ResetText(); // Resetea el objeto
            textBox2.ResetText();
            textBox3.ResetText();
            //textBox1.Clear();   Funcion predeterminada que es limpiar por C#
            //textBox2.Clear();
        }
    }
}
