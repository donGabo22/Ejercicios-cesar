using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Topicos_Tarea1_ProbandoLibreriasdeTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void button1_Click(object sender, EventArgs e)
        {

            //int v1 = (int)Math.Round(double.Parse(txbNumeroInicial.Text));
            //int v2 = (int)Math.Round(double.Parse(txbNumeroFinal.Text));
            //U2_Topicos_Tarea1_BibliotecadeClases.aleatorio.numeroRandom(v1, v2);


            decimal numero1 = decimal.Parse(txbValor1.Text);
            decimal numero2 = decimal.Parse(txbValor2.Text);
            Console.WriteLine(U2_Topicos_Tarea1_BibliotecadeClases2.Multiplicacion.Multiplicar(numero1, numero2));
            lblMultiplicacion.Text = U2_Topicos_Tarea1_BibliotecadeClases2.Multiplicacion.MostrarMultiplicar(numero1, 2);
        }
    }
}
