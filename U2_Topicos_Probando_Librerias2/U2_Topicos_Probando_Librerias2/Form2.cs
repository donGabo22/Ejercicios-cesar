using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Topicos_Probando_Librerias2
{
    public partial class Form2 : Form
    {
        String nombre;
        int edad;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String nombre, int edad)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.edad = edad;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre+ ": "+ edad;

        }
    }
}
