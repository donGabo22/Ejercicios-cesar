using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Topicos_PaletadeColoresClaseV2
{
    public partial class UCPaletaColores: UserControl
    {
        public UCPaletaColores()
        {
            InitializeComponent();
        }

        Color colorUtil;
        ColorDialog objDialog = new ColorDialog();

        public Color SeleccionColor() 
        {
            return colorUtil;
        }


        private void btnPaletaColores_Click(object sender, EventArgs e)
        {
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objDialog.Color;
                SeleccionColor();
            }
        }
    }
}
