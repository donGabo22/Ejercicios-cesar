using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using U3_EXAMEN_PASTELERIA.Models;

namespace U3_EXAMEN_PASTELERIA
{
    public partial class FormInventario : Form
    {
        public int id = 0;
        public FormInventario()
        {
            InitializeComponent();
        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            todoProducto();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            todoProducto();
        }
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void todoProducto()
        {
            using (var context = new ApplicationDBContext())
            {
                var inv = context.Inventarios.ToList();
                dgvInventario.DataSource = inv;
            }
        }
        private void AgregarProducto()
        {
            using (var context = new ApplicationDBContext())
            {
                //paso 1 crear el objeto 
                var Inventario1 = new Inventario();
                Inventario1.Nombre = txbNombre.Text;
                Inventario1.Categoria = cbCategoria.SelectedItem.ToString();
                Inventario1.Uso = cbUso.SelectedItem.ToString();
                Inventario1.CantidadenInventario = txbCantidad.Text;

                Inventario1.FechadeCaducidad = dtpFechaCaducidad.Text;

                //paso 2 notificamos que queremos agregar un empleado

                context.Inventarios.Add(Inventario1);

                //paso 3 guardamos los cambios

                context.SaveChanges();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventarios.First(x => x.Id == id);
                    if (producto != null)
                    {

                        producto.Nombre = txbNombre.Text;
                        producto.Nombre = txbNombre.Text;
                        producto.Categoria = cbCategoria.SelectedItem.ToString();
                        producto.Uso = cbUso.SelectedItem.ToString();
                        producto.CantidadenInventario = txbCantidad.Text;
                        producto.FechadeCaducidad = dtpFechaCaducidad.Text;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var producto = context.Inventarios.First(x => x.Id == id);
                    if (producto != null)
                    {
                        context.Remove(producto);
                        context.SaveChanges();
                        todoProducto(); //?
                    }
                }

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BuscarProducto()
        {
            using (var context = new ApplicationDBContext())
            {
                var emp = context.Inventarios.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvInventario.DataSource = emp;
            }
        }





        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            cbCategoria.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            cbUso.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            txbCantidad.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();
            dtpFechaCaducidad.Value = Convert.ToDateTime(dgvInventario.CurrentRow.Cells[5].Value.ToString());
        }


        private void buscar()
        {
            using (var context = new ApplicationDBContext())
            {
                var p = context.Inventarios.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvInventario.DataSource = p;
            }
        }


    }


}

