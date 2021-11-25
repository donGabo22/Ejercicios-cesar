using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U1_Topicos_InterfazGrafica.Models;

namespace U1_Topicos_InterfazGrafica
{
    public partial class formClientes : Form
    {
        public int id = 0;
        public formClientes()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
            TodoCliente();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            TodoCliente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            TodoCliente();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            TodoCliente();
        }
        private void TodoCliente()
        {
            using (var context = new ApplicationDbContext())
            {
                //select * from clientes
                var clientesList = context.Clientes.ToList();
                dgvClientes.DataSource = clientesList;

            }

        }
        private void AgregarClientes()
        {
            using (var context = new ApplicationDbContext())
            {
            //  Crear el objeto
                var cliente = new Clientes();
                cliente.Nombre = txbNombre.Text;
                cliente.ApellidoPaterno = txbApellidoPaterno.Text;
                cliente.ApellidoMaterno = txbApellidoMaterno.Text;
                cliente.Sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
                cliente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                cliente.RFC = txbRFC.Text;

                //Notificamos a EFC el agregar un cliente
                context.Clientes.Add(cliente);

                //Guardamos los cambios
                context.SaveChanges();
            }
        }
        private void ModificarCliente()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var cliente = context.Clientes.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        cliente.Nombre = txbNombre.Text;
                        cliente.ApellidoPaterno = txbApellidoPaterno.Text;
                        cliente.ApellidoMaterno = txbApellidoMaterno.Text;
                        cliente.Sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
                        cliente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        cliente.RFC = txbRFC.Text;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            txbNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txbApellidoPaterno.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txbApellidoMaterno.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            if (dgvClientes.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbFemenino.Checked = true;
            }
            else
            {
                rbMasculino.Checked = true;
            }
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells[5].Value.ToString());
            txbRFC.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
        }
        private void EliminarCliente()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var cliente = context.Clientes.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        context.Remove(cliente);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
