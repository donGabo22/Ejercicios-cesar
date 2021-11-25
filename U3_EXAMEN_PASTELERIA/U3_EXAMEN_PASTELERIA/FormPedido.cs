using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using U3_EXAMEN_PASTELERIA.Models;

namespace U3_EXAMEN_PASTELERIA
{
    public partial class FormPedido : Form
    {
        public int id = 0;
        public FormPedido()
        {
            InitializeComponent();
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            todoPedido();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var pedidos = context.Pedidos.First(x => x.Id == id);
                    if (pedidos != null)
                    {

                        pedidos.NombredelCliente = txbNombre.Text;
                        pedidos.DirecciondelCliente = txbDireccion.Text;
                        pedidos.NumerodeCelular = txbCelular.Text;
                        pedidos.TipodePastel = txbTipo.Text;
                        pedidos.Precio = txbPrecio.Text;

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
                    var pedidos = context.Pedidos.First(x => x.Id == id);
                    if (pedidos != null)
                    {
                        context.Remove(pedidos);
                        context.SaveChanges();

                        todoPedido(); //?
                    }
                }

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarPedido();
            todoPedido();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();

        }



        private void buscarClientes()
        {
            using (var context = new ApplicationDBContext())
            {
                var pedir = context.Pedidos.Where(x => x.NombredelCliente.Contains(txbBuscar.Text)).ToList();
                dataGridView1.DataSource = pedir;
            }
        }
        private void buscar()
        {
            using (var context = new ApplicationDBContext())
            {
                var p = context.Pedidos.Where(x => x.NombredelCliente.Contains(txbBuscar.Text)).ToList();
                dataGridView1.DataSource = p;
            }
        }

        private void AgregarPedido()
        {
            using (var context = new ApplicationDBContext())
            {
                //paso 1 crear el objeto 
                var pedido1 = new Pedido();
                pedido1.NombredelCliente = txbNombre.Text;
                pedido1.DirecciondelCliente = txbDireccion.Text;
                pedido1.NumerodeCelular = txbCelular.Text;
                pedido1.TipodePastel = txbTipo.Text;

                pedido1.Precio = txbPrecio.Text;

                //paso 2 notificamos que queremos agregar un empleado

                context.Pedidos.Add(pedido1);

                //paso 3 guardamos los cambios

                context.SaveChanges();

            }
        }

        private void todoPedido()
        {
            using (var context = new ApplicationDBContext())
            {
                var inv = context.Pedidos.ToList();
                dataGridView1.DataSource = inv;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txbCelular.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txbTipo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txbPrecio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
