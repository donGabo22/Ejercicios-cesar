using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void rbSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuma.Checked == true)
            {
                rbSuma.Enabled = true;
                rbResta.Enabled = false;
                rbMultiplicacion.Enabled = false;
                rbDivision.Enabled = false;
            }
       
        }

        private void rbResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbResta.Checked == true)
            {
                rbResta.Enabled = true;
                rbSuma.Enabled = false;
                rbMultiplicacion.Enabled = false;
                rbDivision.Enabled = false;
            }
        }

        private void rbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMultiplicacion.Checked == true)
            {
                rbMultiplicacion.Enabled = true;
                rbResta.Enabled = false;
                rbSuma.Enabled = false;
                rbDivision.Enabled = false;
            }
        }

        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivision.Checked==true)
            { 
            rbDivision.Enabled = true;
            rbResta.Enabled = false;
            rbSuma.Enabled = false;
            rbMultiplicacion.Enabled = false;
        }
    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado;
            double a = double.Parse(txbValor1.Text);
            double b = double.Parse(txbValor2.Text);
            if (rbSuma.Checked==true)
            {


                resultado = a + b;
                lblResultado.Text = " " + resultado;
            }

            if (rbResta.Checked == true)
            {

                resultado = a-b;
                lblResultado.Text = " " + resultado;
            }
            if (rbMultiplicacion.Checked == true)
            {

                resultado = a * b;
                lblResultado.Text = " " + resultado;
            }

            if (rbDivision.Checked == true)
            {

                resultado = a / b;
                lblResultado.Text = " " + resultado;
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbValor1.Text = "";
            txbValor2.Text = "";
            rbDivision.Enabled = true;
            rbResta.Enabled = true;
            rbSuma.Enabled = true;
            rbMultiplicacion.Enabled = true;
        }
    }
}
