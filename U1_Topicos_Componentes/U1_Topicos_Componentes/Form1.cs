using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarNombre_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Gabriel Hernandez"); //sirve para hacer click
            string nombre = txtNombre.Text;
            bool femenino = chbFemenino.Checked;
            if (femenino == true) 
            { 
                nombre = nombre + " Eres Mujer";
            }
            else
            {
                nombre = nombre + " Eres Hombre";
            }
            MessageBox.Show(nombre);
        }

        private void btnMostrarNombre_MouseEnter(object sender, EventArgs e)
        {
       //  MessageBox.Show("ya le picaste we"); sirve para accionar el boton con tan solo apuntar con el mouse
       

        }

        private void chbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            bool femenino =chbFemenino.Checked;
            MessageBox.Show(femenino.ToString());  
        }
    }
}
