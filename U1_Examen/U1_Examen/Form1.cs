using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vacabailando.Image = Image.FromFile(@"C:\Users\gabri\OneDrive\Escritorio\vaca2.gif ");
            vacabailando.SizeMode = PictureBoxSizeMode.AutoSize;

            txbValorUnitario.Text = "0";
            txbCantidad.Text = "0";
        }

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            lblUsuarioNoAdimitido.Text = "";
            string nombre = txbUsuario.Text;

            if (txbContraseña.Text != "" & txbUsuario.Text!="")
            {

                lblPerfil.Text = "Bienvenido " + nombre.ToString();
                lblproducto.Visible = true;
                txbProducto.Visible = true;

                lblproovedor.Visible = true;
                txbProveedor.Visible = true;

                lbltipo.Visible = true;
                cbxProductos.Visible = true;

                lblFechaRegistro.Visible = true;
                dtpfechaRegistro.Visible = true;

                lblFechaCaducidad.Visible = true;
                dtpfechaCaducidad.Visible = true;

                lblValorUnitario.Visible = true;
                txbValorUnitario.Visible = true;

                lblCantidad.Visible = true;
                txbCantidad.Visible = true;
                lblMenu.Visible = true;
                btnLimpiar.Visible = true;
                btnRegistrar.Visible = true;
                lblMenu.Visible = true;
                dgvTabla.Visible = true;

                btnIniciarSeccion.Visible = false;
            }
            else
            {
            lblUsuarioNoAdimitido.Text = "Contraseña O Nombre de Usuario Incorrecto";
            }
        }

   

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int n = dgvTabla.Rows.Add();
            dgvTabla.Rows[n].Cells[0].Value = txbProducto.Text;
            dgvTabla.Rows[n].Cells[1].Value = txbProveedor.Text;
            dgvTabla.Rows[n].Cells[2].Value = cbxProductos.Text;
            dgvTabla.Rows[n].Cells[3].Value = dtpfechaRegistro.Value.ToString();
            dgvTabla.Rows[n].Cells[4].Value = dtpfechaCaducidad.Value.ToString();
            dgvTabla.Rows[n].Cells[5].Value = txbValorUnitario.Text +" $";
            dgvTabla.Rows[n].Cells[6].Value = txbCantidad.Text;





        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCantidad.Text = "0";
            txbProducto.Text = "";
            txbProveedor.Text = "";
            txbValorUnitario.Text = "0";
            dtpfechaRegistro.Value = DateTime.Now;
            dtpfechaCaducidad.Value = DateTime.Now;
            cbxProductos.Text = "";




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
