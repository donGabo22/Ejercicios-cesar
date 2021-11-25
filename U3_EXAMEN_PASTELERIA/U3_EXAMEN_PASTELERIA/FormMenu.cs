using System;
using System.Windows.Forms;

namespace U3_EXAMEN_PASTELERIA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPedido frmpedido = new FormPedido();
            frmpedido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();
            frmInventario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
