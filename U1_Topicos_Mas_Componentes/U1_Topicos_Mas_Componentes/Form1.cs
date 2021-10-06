using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Topicos_Mas_Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                int n = DGVregistros.Rows.Add();
                DGVregistros.Rows[n].Cells[0].Value=txtNombre.Text;
                DGVregistros.Rows[n].Cells[1].Value = txbApellido.Text;
                DGVregistros.Rows[n].Cells[2].Value = txbCorreo.Text;
                DGVregistros.Rows[n].Cells[3].Value = txbContraseña.Text;
                DGVregistros.Rows[n].Cells[4].Value = rbtFemenino.Checked ? "Femenino": "Masculino";

                if (chbPeliculas.Checked && chbSeries.Checked) 
                {
                    DGVregistros.Rows[n].Cells[5].Value = "Peliculas y Series ";
                }
                else if (chbPeliculas.Checked && ! chbSeries.Checked)
                {
                    DGVregistros.Rows[n].Cells[5].Value = "Peliculas";

                }
                else if (!chbPeliculas.Checked && chbSeries.Checked)
                {
                    DGVregistros.Rows[n].Cells[5].Value = "Series";
                }
                else
                {
                    DGVregistros.Rows[n].Cells[5].Value = "Ninguna";
                }
                foreach (var item in chlbGeneros.CheckedItems)
                {
                    DGVregistros.Rows[n].Cells[6].Value = DGVregistros.Rows[n].Cells[6].Value +
                        item.ToString()+    ", ";
                }

                DGVregistros.Rows[n].Cells[7].Value = cbCarreras.SelectedItem;
                DGVregistros.Rows[n].Cells[8].Value = dtpFechaNacimiento.Value.ToString(); 


            }
            else
            {
                MessageBox.Show("Los campos nombre, apellidos, correo y passwors son obligatorios");
            }
        }

        bool validacion()
        {
            bool[] validar = new bool[4];
            // Nombre (TextBox)
            validar[0]= txtNombre.Text != "" ? true :false;

            //Apellidos(TextBox)
            if (txbApellido.Text != "")
            {
                validar[1] = true;
            }
            else
            {
                validar[1] = false;
            }
            //Correo
            validar[2] = txbCorreo.Text != "" ? true : false;

            //Password
            validar[3] = txbContraseña.Text != "" ? true : false;

            foreach (var item in validar)
            {
                if (item==false)
                {
                    return false;

                }

            }
            return true;






        }
    }
}
