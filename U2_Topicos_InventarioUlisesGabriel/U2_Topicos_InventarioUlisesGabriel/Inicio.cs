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
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (txbUsuario.Text=="Admin" && (txbContraseña.Text =="pass"))
            {
                MessageBox.Show("vamos");
                Inv.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("error de usuario");
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
    }
}
