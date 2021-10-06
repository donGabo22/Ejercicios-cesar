using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

 
        private void btn1_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "9";

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "0";

        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "+";



        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "-";

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "*";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txbDigitos.Text += "/";

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
         //   double resultado = double.Parse(txbDigitos.Text);
            String resultado = txbDigitos.Text;

            Expression sol = new Expression(resultado);
            lblresultado.Text = " " + sol.Evaluate().ToString();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbDigitos.Text = "";
            lblresultado.Text = "";
        }
    }
}
