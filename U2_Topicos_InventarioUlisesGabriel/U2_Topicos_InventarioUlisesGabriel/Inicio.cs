using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Topicos_InventarioUlisesGabriel
{
    
    public partial class Inicio : Form
    {
        
        Inventario Inv = new Inventario();
        Form1 lolipop = new Form1();


        public Inicio()
        {
            InitializeComponent();
            
        }



        public void btnLogin_Click(object sender, EventArgs e)
        {
            String nombre = txbUsuario.Text;
            String contraseña = txbContraseña.Text;
            RegistroParaElInicio login = new RegistroParaElInicio();

         //   RegistroParaElInicio(nombre, int.Parse(contraseña);

            //   if (txbUsuario.Text == nombre && (txbContraseña.Text == pass))
            if (txbUsuario.Text=="Admin" && (txbContraseña.Text =="pass"))
            {

                this.Hide();
                lolipop.ShowDialog();
                MessageBox.Show("vamos");
                Inv.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("error , contraseña o usuario invalido");
                txbUsuario.Text="";
                txbContraseña.Text = "";
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroParaElInicio formRegistro = new RegistroParaElInicio();
            formRegistro.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MetodoNombre(string N)
        {
            N = txbUsuario.Text;
            MessageBox.Show("" + N);
            return N;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
