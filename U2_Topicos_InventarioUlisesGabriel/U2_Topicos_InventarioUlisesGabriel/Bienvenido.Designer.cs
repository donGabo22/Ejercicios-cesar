
namespace U2_Topicos_InventarioUlisesGabriel
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombredeBienvenido = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHoraBienvenido = new System.Windows.Forms.Label();
            this.lblFechaBienvenido = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(76, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2_Topicos_InventarioUlisesGabriel.Properties.Resources.azul;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO";
            // 
            // lblNombredeBienvenido
            // 
            this.lblNombredeBienvenido.AutoSize = true;
            this.lblNombredeBienvenido.Location = new System.Drawing.Point(8, 54);
            this.lblNombredeBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombredeBienvenido.Name = "lblNombredeBienvenido";
            this.lblNombredeBienvenido.Size = new System.Drawing.Size(54, 15);
            this.lblNombredeBienvenido.TabIndex = 4;
            this.lblNombredeBienvenido.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::U2_Topicos_InventarioUlisesGabriel.Properties.Resources.inventario;
            this.pictureBox2.Location = new System.Drawing.Point(116, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblHoraBienvenido
            // 
            this.lblHoraBienvenido.AutoSize = true;
            this.lblHoraBienvenido.Location = new System.Drawing.Point(355, 23);
            this.lblHoraBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraBienvenido.Name = "lblHoraBienvenido";
            this.lblHoraBienvenido.Size = new System.Drawing.Size(34, 15);
            this.lblHoraBienvenido.TabIndex = 7;
            this.lblHoraBienvenido.Text = "hora:";
            // 
            // lblFechaBienvenido
            // 
            this.lblFechaBienvenido.AutoSize = true;
            this.lblFechaBienvenido.Location = new System.Drawing.Point(239, 0);
            this.lblFechaBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaBienvenido.Name = "lblFechaBienvenido";
            this.lblFechaBienvenido.Size = new System.Drawing.Size(39, 15);
            this.lblFechaBienvenido.TabIndex = 8;
            this.lblFechaBienvenido.Text = "fecha:";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Location = new System.Drawing.Point(67, 54);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(53, 15);
            this.NombreUsuario.TabIndex = 9;
            this.NombreUsuario.Text = "No se xd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 268);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFechaBienvenido);
            this.Controls.Add(this.lblHoraBienvenido);
            this.Controls.Add(this.lblNombredeBienvenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpBienvenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombredeBienvenido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHoraBienvenido;
        private System.Windows.Forms.Label lblFechaBienvenido;
        private System.Windows.Forms.DateTimePicker dtpHoraBienvenido;
        private System.Windows.Forms.Label NombreUsuario;
    }
}