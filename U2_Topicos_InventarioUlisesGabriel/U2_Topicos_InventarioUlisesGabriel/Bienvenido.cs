using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace U2_Topicos_InventarioUlisesGabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        DateTime hoy = DateTime.Now;
        public void Form1_Load(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            // string nombre = i.txbUsuario.toString();

            lblFechaBienvenido.Text = hoy.ToLongDateString();
            lblHoraBienvenido.Text = hoy.ToShortTimeString();
            String n=NombreUsuario.Text;
            String no=i.MetodoNombre(n);
            NombreUsuario.Text = no;

            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
