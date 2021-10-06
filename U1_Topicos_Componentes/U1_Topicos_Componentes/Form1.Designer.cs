
namespace U1_Topicos_Componentes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarNombre = new System.Windows.Forms.Button();
            this.chbMasculino = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.chbFemenino = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMostrarNombre
            // 
            this.btnMostrarNombre.Location = new System.Drawing.Point(485, 85);
            this.btnMostrarNombre.Name = "btnMostrarNombre";
            this.btnMostrarNombre.Size = new System.Drawing.Size(166, 34);
            this.btnMostrarNombre.TabIndex = 0;
            this.btnMostrarNombre.Text = "MostrarNombre";
            this.btnMostrarNombre.UseVisualStyleBackColor = true;
            this.btnMostrarNombre.Click += new System.EventHandler(this.btnMostrarNombre_Click);
            this.btnMostrarNombre.MouseEnter += new System.EventHandler(this.btnMostrarNombre_MouseEnter);
            // 
            // chbMasculino
            // 
            this.chbMasculino.AutoSize = true;
            this.chbMasculino.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chbMasculino.Location = new System.Drawing.Point(133, 221);
            this.chbMasculino.Name = "chbMasculino";
            this.chbMasculino.Size = new System.Drawing.Size(118, 29);
            this.chbMasculino.TabIndex = 1;
            this.chbMasculino.Text = "Masculino";
            this.chbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gold;
            this.lblNombre.Location = new System.Drawing.Point(22, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Lime;
            this.txtNombre.Location = new System.Drawing.Point(133, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "ingresa tu nombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 31);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Gold;
            this.lblEmail.Location = new System.Drawing.Point(22, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Lime;
            this.txtEmail.Location = new System.Drawing.Point(133, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "ingresa tu Email";
            this.txtEmail.Size = new System.Drawing.Size(305, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.Color.Gold;
            this.lblContraseña.Location = new System.Drawing.Point(22, 145);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(105, 25);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.ForeColor = System.Drawing.Color.Lime;
            this.txtContraseña.Location = new System.Drawing.Point(133, 145);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderText = "ingresa tu contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(305, 31);
            this.txtContraseña.TabIndex = 7;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.Gold;
            this.lblSexo.Location = new System.Drawing.Point(12, 220);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 25);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo";
            // 
            // chbFemenino
            // 
            this.chbFemenino.AutoSize = true;
            this.chbFemenino.Checked = true;
            this.chbFemenino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFemenino.ForeColor = System.Drawing.Color.DeepPink;
            this.chbFemenino.Location = new System.Drawing.Point(260, 220);
            this.chbFemenino.Name = "chbFemenino";
            this.chbFemenino.Size = new System.Drawing.Size(116, 29);
            this.chbFemenino.TabIndex = 9;
            this.chbFemenino.Text = "Femenino";
            this.chbFemenino.UseVisualStyleBackColor = true;
            this.chbFemenino.CheckedChanged += new System.EventHandler(this.chbFemenino_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 703);
            this.Controls.Add(this.chbFemenino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chbMasculino);
            this.Controls.Add(this.btnMostrarNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarNombre;
        private System.Windows.Forms.CheckBox chbMasculino;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox chbFemenino;
    }
}

