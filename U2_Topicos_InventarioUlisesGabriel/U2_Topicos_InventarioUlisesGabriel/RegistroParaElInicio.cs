using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace U2_Topicos_InventarioUlisesGabriel
{
    public partial class RegistroParaElInicio : Form
    {
        public RegistroParaElInicio()
        {
            InitializeComponent();
        }

        //public RegistroParaElInicio(String nombre, int pass)
        //{
        //    InitializeComponent();
        //    this.txbNombreIS = txbNombreIS;
        //    this.txbContraseñaIS = txbContraseñaIS;
        //}


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100) {
                timer1.Stop();
                timer2.Start();
            }
            }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0){
                timer2.Stop();
                this.Close();
            }
        }
        private void btnFinalizarRegistro_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();



        }
    }
}
