
namespace U2_Topicos_Tarea1_ProbandoComponentes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBotonConSonido1 = new U2_Topicos_Tarea1_Componente.UCBotonConSonido();
            this.SuspendLayout();
            // 
            // ucBotonConSonido1
            // 
            this.ucBotonConSonido1.BackColor = System.Drawing.Color.Transparent;
            this.ucBotonConSonido1.Location = new System.Drawing.Point(216, 134);
            this.ucBotonConSonido1.Name = "ucBotonConSonido1";
            this.ucBotonConSonido1.Size = new System.Drawing.Size(337, 208);
            this.ucBotonConSonido1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucBotonConSonido1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private U2_Topicos_Tarea1_Componente.UCBotonConSonido ucBotonConSonido1;
    }
}

