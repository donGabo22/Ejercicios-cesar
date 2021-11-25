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
    public partial class frmClientes2 : Form
    {
        public frmClientes2()
        {
            InitializeComponent();
        }

        private void frmClientes2_Load(object sender, EventArgs e)
        {
            TodoClientes();
        }

        private void TodoClientes()
        {
            using (var context = new ApplicationDbContext())
            {
                //select * from clientes
                var clientesList = context.Clientes.ToList();
                dgvClientes.DataSource = clientesList;
            }
        }
    }
}
