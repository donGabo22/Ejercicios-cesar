
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
            this.progressBar1.Location = new System.Drawing.Point(108, 394);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 38);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2_Topicos_InventarioUlisesGabriel.Properties.Resources.azul;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO";
            // 
            // lblNombredeBienvenido
            // 
            this.lblNombredeBienvenido.AutoSize = true;
            this.lblNombredeBienvenido.Location = new System.Drawing.Point(12, 90);
            this.lblNombredeBienvenido.Name = "lblNombredeBienvenido";
            this.lblNombredeBienvenido.Size = new System.Drawing.Size(82, 25);
            this.lblNombredeBienvenido.TabIndex = 4;
            this.lblNombredeBienvenido.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::U2_Topicos_InventarioUlisesGabriel.Properties.Resources.inventario;
            this.pictureBox2.Location = new System.Drawing.Point(166, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblHoraBienvenido
            // 
            this.lblHoraBienvenido.AutoSize = true;
            this.lblHoraBienvenido.Location = new System.Drawing.Point(507, 38);
            this.lblHoraBienvenido.Name = "lblHoraBienvenido";
            this.lblHoraBienvenido.Size = new System.Drawing.Size(52, 25);
            this.lblHoraBienvenido.TabIndex = 7;
            this.lblHoraBienvenido.Text = "hora:";
            // 
            // lblFechaBienvenido
            // 
            this.lblFechaBienvenido.AutoSize = true;
            this.lblFechaBienvenido.Location = new System.Drawing.Point(342, 0);
            this.lblFechaBienvenido.Name = "lblFechaBienvenido";
            this.lblFechaBienvenido.Size = new System.Drawing.Size(58, 25);
            this.lblFechaBienvenido.TabIndex = 8;
            this.lblFechaBienvenido.Text = "fecha:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 446);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFechaBienvenido);
            this.Controls.Add(this.lblHoraBienvenido);
            this.Controls.Add(this.lblNombredeBienvenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}