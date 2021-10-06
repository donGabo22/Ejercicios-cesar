using System;
using System.Windows.Forms;

namespace U1_Topicos_CajaRegistradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            txbManzana.Text = "0";
            txbNaranja.Text = "0";
            txbPiña.Text = "0";
            txbPlatano.Text = "0";
            txbPera.Text = "0";
            txbSandia.Text = "0";

            txbLeche.Text = "0";
            txbHuevo.Text = "0";
            txbRTX.Text = "0";

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            btnPagar.Enabled = true;
            btnLimpiar.Enabled = true;
            //Sacando naranja
            double Naranja = double.Parse(txbNaranja.Text);
            double Manzana = double.Parse(txbManzana.Text);
            double piña = double.Parse(txbPiña.Text);
            double platano = double.Parse(txbPlatano.Text);
            double pera = double.Parse(txbPera.Text);
            double sandia = double.Parse(txbSandia.Text);

            double resultadofruta;
            resultadofruta = (Naranja * 19.90) + (Manzana * 29.90) + (piña * 23.90) + (platano * 9.90) + (pera * 69.90) + (sandia * 10.90);
            lblFruta.Text = " " + resultadofruta;

            //    int huevo = int.Parse(txbHuevo.Text);
            int huevo = (int)Math.Round(double.Parse(txbHuevo.Text));
            int leche = (int)Math.Round(double.Parse(txbLeche.Text));
            int RTX =   (int)Math.Round(double.Parse(txbRTX.Text));


            double resultadoOtros;
            resultadoOtros = (leche * 20) + (huevo * 5) + (RTX * 40000);
            lblOtros.Text = " " + resultadoOtros;

            double resultadoFO;
            resultadoFO = resultadofruta + resultadoOtros;
            lblTotal.Text = " " + resultadoFO;






        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            lblcambioInsuficiente.Text = "";
            double ticket = double.Parse(txbCambio.Text);
            double total = double.Parse(lblTotal.Text);
            double cambio;

            if (ticket >= total)
            {
                cambio = ticket - total;
                lblCambio.Text = " " + cambio;

                Random rand = new Random();
                int num = rand.Next(1, 100);

                int n = DGVTabla.Rows.Add();
                DGVTabla.Rows[n].Cells[0].Value = num.ToString();
                DGVTabla.Rows[n].Cells[1].Value = lblFruta.Text;
                DGVTabla.Rows[n].Cells[2].Value = lblOtros.Text;
                DGVTabla.Rows[n].Cells[3].Value = lblTotal.Text;
                DGVTabla.Rows[n].Cells[4].Value = lblCambio.Text;




                btnPagar.Enabled = true;
                btnLimpiar.Enabled = true;

            }
            else
            {
                lblcambioInsuficiente.Text = "CAMBIO INSUFICIENTE";
            }




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            lblTotal.Text = "";
            lblOtros.Text = "";
            lblFruta.Text = "";
            lblCambio.Text = "";
            txbCambio.Text = "0";


            txbManzana.Text = "0";
            txbNaranja.Text = "0";
            txbPiña.Text = "0";
            txbPlatano.Text = "0";
            txbPera.Text = "0";
            txbSandia.Text = "0";

            txbLeche.Text = "0";
            txbHuevo.Text = "0";
            txbRTX.Text = "0";
        }
    }
}
