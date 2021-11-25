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
    public partial class frmInventario : Form
    {
        public int id = 0;
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventario.First(x => x.Id == id);
                    if (producto != null)
                    {
                        context.Remove(producto);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventario.First(x => x.Id == id);
                    if (producto != null)
                    {
                        producto.Nombre = txbNombre.Text;
                        producto.TipodeProducto = txbTipo.Text;
                        producto.Precio = txbprecio.Text;
                        producto.CantidadEnInventario = txbCantidad.Text;
                        producto.FechaCreacion = dtpFechaEntrada.Value.Date;
                        producto.TechadeCaducidad = dtpFechaCaducidad.Text;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            TodoProducto();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            TodoProducto();
        }

        private void TodoProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var producto = context.Inventario.ToList();
                dgvInventario.DataSource = producto;
            }
        }
            private void AgregarProducto()
            {
                using (var context = new ApplicationDbContext())
                {
                    //paso 1 crear el objeto 
                    var Inventario1 = new Inventario();
                Inventario1.Nombre = txbNombre.Text;
                Inventario1.TipodeProducto = txbTipo.Text;
                Inventario1.Precio = txbprecio.Text;
                Inventario1.CantidadEnInventario = txbCantidad.Text;
                Inventario1.FechaCreacion = dtpFechaEntrada.Value.Date;
                Inventario1.TechadeCaducidad = dtpFechaCaducidad.Text;

                    //paso 2 notificamos que queremos agregar un empleado

                    context.Inventario.Add(Inventario1);

                    //paso 3 guardamos los cambios

                    context.SaveChanges();
                }

            }

        private void BuscarProducto()
        {
            using (var context = new ApplicationDbContext())
            {
                var producto = context.Inventario.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvInventario.DataSource = producto;
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            txbTipo.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            txbprecio.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            txbCantidad.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();

            dtpFechaEntrada.Value = Convert.ToDateTime(dgvInventario.CurrentRow.Cells[5].Value.ToString());
            dtpFechaCaducidad.Value = Convert.ToDateTime(dgvInventario.CurrentRow.Cells[6].Value.ToString());

        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
           
                BuscarProducto();
            
        }

  
    }
    }

