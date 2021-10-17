
namespace U2_Topicos_paletadeColores
{
    partial class UCPaletaClase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPaletaColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaletaColores
            // 
            this.btnPaletaColores.BackgroundImage = global::U2_Topicos_paletadeColores.Properties.Resources.circulo_cromatico;
            this.btnPaletaColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaletaColores.Location = new System.Drawing.Point(0, 0);
            this.btnPaletaColores.Name = "btnPaletaColores";
            this.btnPaletaColores.Size = new System.Drawing.Size(250, 250);
            this.btnPaletaColores.TabIndex = 0;
            this.btnPaletaColores.Text = "Paleta de Colores";
            this.btnPaletaColores.UseVisualStyleBackColor = true;
            this.btnPaletaColores.Click += new System.EventHandler(this.btnPaletaColores_Click);
            // 
            // UCPaletaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaletaColores);
            this.Name = "UCPaletaClase";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaletaColores;
    }
}
