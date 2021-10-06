using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_conversordeTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     //       pictureBox1.Image = Image.FromFile(@"C:\Users\gabri\OneDrive\Escritorio\tiburon.gif ");
     //       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          //  pictureBox1.Image = Image.FromFile(@"C:\Users\gabri\OneDrive\Escritorio\tiburon.gif ");
          //  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Para convertir de ºC a ºF use la fórmula: ºF = ºC x 1.8 + 32.
            //Para convertir de ºF a ºC use la fórmula: ºC = (ºF - 32) ÷ 1.8.
            //Para convertir de K a ºC use la fórmula: ºC = K – 273.15.
            //Para convertir de ºC a K use la fórmula: K = ºC + 273.15.
            //double c= Convert.ToDouble(txbCentigrados.Text);
            //double f = Convert.ToDouble(txbFarenheit.Text);
            //double k = Convert.ToDouble(txbKelvin.Text);
            double resultado;
            if (txbCentigrados.Text !="")
            {
                double c = double.Parse(txbCentigrados.Text);
               
                //CENTIGRADOS A FARENHEITH
                resultado = c * 1.8 + 32;
                txbFarenheit.Text = resultado.ToString();
                // CENTIGRADOS A KELVIN
                resultado = c + 273.15;
                txbKelvin.Text = resultado.ToString();

            }
            if (txbFarenheit.Text!="")
            {

                double f = double.Parse(txbFarenheit.Text);
                //FARENHEIT A CENTIGRADOS
                resultado = (f - 32) / 1.8;
                txbCentigrados.Text = resultado.ToString();

                //FARENHEIT A KELVIN
                resultado = ((f - 32) * 5 / 9) + 273.15;
                txbKelvin.Text = resultado.ToString();

            }
            if (txbKelvin.Text!="")
            {
                double k = double.Parse(txbKelvin.Text);

                //KELVIN A CENTIGRADOS
                resultado = k - 273.15;
                txbCentigrados.Text = resultado.ToString();

                //KELVIN A FARENHEITH
                resultado = ((k - 273.15) * 1.80) + 32;
                txbFarenheit.Text = resultado.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txbCentigrados.Text = "";
            txbFarenheit.Text = "";
            txbKelvin.Text = "";
        }
    }
}
