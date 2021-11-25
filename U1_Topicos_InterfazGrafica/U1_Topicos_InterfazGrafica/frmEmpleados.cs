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
    public partial class frmEmpleados : Form
    {
        public int id=0;
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            TodoEmpleados();
        }

        private void button1_Click(object sender, EventArgs e)//registrar
        {
            AgregarEmpleado();
            TodoEmpleados();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }
  

        private void TodoEmpleados()
        {
            using (var context = new ApplicationDbContext())
            {
                var empleados = context.Empleado.ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void AgregarEmpleado()
        {
            using (var context = new ApplicationDbContext())
            {
                //paso 1 crear el objeto 
                var empleado1 = new Empleados();
                empleado1.Nombre = txbNombre.Text;
                empleado1.ApellidoPaterno = txbApellidoPaterno.Text;
                empleado1.ApellidoMaterno = txbApellidoMaterno.Text;
                empleado1.Sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
                empleado1.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                empleado1.RFC = txbRFC.Text;

                //paso 2 notificamos que queremos agregar un empleado

                context.Empleado.Add(empleado1);

                //paso 3 guardamos los cambios

                context.SaveChanges();
            }

        }
        private void BuscarEmpleado()
        {
            using (var context = new ApplicationDbContext())
            {
                var empleados = context.Empleado.Where(x => x.Nombre.Contains(txbBuscar.Text)).ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            txbNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txbApellidoPaterno.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txbApellidoMaterno.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            if (dgvEmpleados.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbFemenino.Checked = true;
            }
            else
            {
                rbMasculino.Checked = true;
            }
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[5].Value.ToString());
            txbRFC.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var empleado = context.Empleado.First(x => x.Id == id);
                    if (empleado != null)
                    {
                        empleado.Nombre = txbNombre.Text;
                        empleado.ApellidoPaterno = txbApellidoPaterno.Text;
                        empleado.ApellidoMaterno = txbApellidoMaterno.Text;
                        empleado.Sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
                        empleado.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        empleado.RFC = txbRFC.Text;
                        context.SaveChanges();
                    }
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var empleado = context.Empleado.First(x => x.Id == id);
                    if (empleado != null)
                    {
                        context.Remove(empleado);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}