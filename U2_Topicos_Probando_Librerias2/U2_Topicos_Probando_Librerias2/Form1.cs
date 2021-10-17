using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Topicos_Probando_Librerias2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = U2_Topicos_Operaciones.sumatoria.MostrarSuma(12.9m, 9.0m);
            Console.WriteLine(U2_Topicos_Operaciones.sumatoria.Sumar(12.9m, 9.0m));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(txtNombre.Text, int.Parse(txtEdad.Text));
            fm.Show();
        }
    }
}
