using System;
using System.Drawing;
using System.Windows.Forms;

namespace U2_Topicos_paletadeColores
{
    public partial class UCPaletaClase : UserControl
    {
        public UCPaletaClase()
        {
            InitializeComponent();
        }
        
        
        Color colorUtil;
        ColorDialog objDialog = new ColorDialog();
        private void btnPaletaColores_Click(object sender, EventArgs e)
        {
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objDialog.Color;
                SeleccionColor();

            }
        }

        public Color SeleccionColor()
        {
            return colorUtil;
        }
    }
}
