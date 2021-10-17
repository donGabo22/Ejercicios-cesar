namespace U2_Topicos_PaletadeColoresClaseV2
{
    partial class UCPaletaColores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPaletaColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaletaColores
            // 
            this.btnPaletaColores.BackgroundImage = global::U2_Topicos_PaletadeColoresClaseV2.Properties.Resources.circulo_cromatico;
            this.btnPaletaColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaletaColores.Location = new System.Drawing.Point(0, 0);
            this.btnPaletaColores.Name = "btnPaletaColores";
            this.btnPaletaColores.Size = new System.Drawing.Size(250, 250);
            this.btnPaletaColores.TabIndex = 0;
            this.btnPaletaColores.Text = "Paleta de Colores";
            this.btnPaletaColores.UseVisualStyleBackColor = true;
            this.btnPaletaColores.Click += new System.EventHandler(this.btnPaletaColores_Click);
            // 
            // UCPaletaColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaletaColores);
            this.Name = "UCPaletaColores";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaletaColores;
    }
}
