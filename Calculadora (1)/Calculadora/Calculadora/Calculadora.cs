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

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "6";
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "9";
        }

        private void btnmultiplic_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "*";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "-";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "+";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            txbxResult.Text += "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            String igual = txbxResult.Text;
            Expression sol = new Expression(igual);
            txbxResult.Text = " " + sol.Evaluate().ToString();
        }

        private void btntodo_Click(object sender, EventArgs e)
        {
            txbxResult.Text = "hola";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
