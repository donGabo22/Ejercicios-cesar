using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace U2_Topicos_Tarea1_Componente
{
    public partial class UCBotonConSonido : UserControl
    {
        public UCBotonConSonido()
        {
            //this.FlatStyle = FlatStyle.Flat;
            //this.FlatAppearance.BorderSize = 0;
            //this.Size = new Size(150, 40);
            //this.BackColor = Color.MediumSlateBlue;
            //this.ForeColor = Color.White;

            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        //fields
        //private int botderSize = 0;
        //private int borderRadius = 40;
        //private Color borderColor = Color.Aqua;
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\OneDrive\Escritorio\sonido.wav");
            simpleSound.Play();

        }

      


    }
}
