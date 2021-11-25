using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_PROYECTO_ULISES_Y_GABRIEL_V2
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("d/MM/yyyy");
            lblHoraandFecha.Text = DateTime.Now.ToString();

        }
        private void pbMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
