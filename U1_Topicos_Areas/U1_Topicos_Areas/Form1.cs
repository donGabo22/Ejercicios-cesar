using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_Areas
{
    public partial class Form1 : Form
    {
        bool circulo;

        public Form1()
        {
            InitializeComponent();
     
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbAltura.Text = "";
            txbBase.Text = "";
            txbLado.Text = "";
            txbRadio.Text = "";
            lblResultado.Text = "*****";
            rbCirculos.Checked = false;
            rbCuadrado.Checked = false;
            rbTriangulo.Checked = false;



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado;


            if (txbLado.Text != "")
            {
                //Sacando cuadrado
                double c = double.Parse(txbLado.Text);
                resultado = c * c;
                lblResultado.Text = " " + resultado;
            }

            if (txbAltura.Text != "" & txbBase.Text!="")
            {
                //Sacando triangulo
                double h = double.Parse(txbAltura.Text);
                double b = double.Parse(txbBase.Text);
                resultado = (b * h) / 2;

                lblResultado.Text = " " + resultado;


            }

            if (txbRadio.Text !="")
            {
                //Sacando circulo
                double r = double.Parse(txbRadio.Text);
                resultado = Math.PI * (r * r);

                lblResultado.Text = " " + resultado;
            }
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuadrado.Checked==true)
            {
                txbLado.Enabled = true;
                txbAltura.Enabled = false;
                txbBase.Enabled = false;
                txbRadio.Enabled = false;
            }
            //if (!rbCuadrado.Checked)
            //{
            //    txbLado.Enabled = false;

            //}
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked == true)
            {
                txbAltura.Enabled = true;
                txbBase.Enabled = true;
                txbLado.Enabled = false;
                txbRadio.Enabled = false;
            }
            //if (!rbTriangulo.Checked)
            //{
            //    txbAltura.Enabled = false;
            //    txbBase.Enabled = false;


            //}
        }

        private void rbCirculos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirculos.Checked == true)
            {
                txbAltura.Enabled = false;
                txbBase.Enabled = false;
                txbLado.Enabled = false;
                txbRadio.Enabled = true;
            }
        }
    }
}
