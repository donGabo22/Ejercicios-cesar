
namespace U2_Topicos_Tarea1_ProbandoLibreriasdeTarea
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
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.txbNumeroInicial = new System.Windows.Forms.TextBox();
            this.txbNumeroFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.lblAleatorio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(15, 459);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(16, 25);
            this.lblMultiplicacion.TabIndex = 0;
            this.lblMultiplicacion.Text = ".";
            // 
            // txbNumeroInicial
            // 
            this.txbNumeroInicial.Location = new System.Drawing.Point(150, 76);
            this.txbNumeroInicial.Name = "txbNumeroInicial";
            this.txbNumeroInicial.Size = new System.Drawing.Size(150, 31);
            this.txbNumeroInicial.TabIndex = 1;
            // 
            // txbNumeroFinal
            // 
            this.txbNumeroFinal.Location = new System.Drawing.Point(150, 157);
            this.txbNumeroFinal.Name = "txbNumeroFinal";
            this.txbNumeroFinal.Size = new System.Drawing.Size(150, 31);
            this.txbNumeroFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor 2:";
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(91, 65);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(150, 31);
            this.txbValor1.TabIndex = 8;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(89, 125);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(150, 31);
            this.txbValor2.TabIndex = 9;
            // 
            // lblAleatorio
            // 
            this.lblAleatorio.AutoSize = true;
            this.lblAleatorio.Location = new System.Drawing.Point(95, 8);
            this.lblAleatorio.Name = "lblAleatorio";
            this.lblAleatorio.Size = new System.Drawing.Size(80, 25);
            this.lblAleatorio.TabIndex = 10;
            this.lblAleatorio.Text = "Random";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAleatorio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbNumeroFinal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbNumeroInicial);
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 270);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2_Topicos_Tarea1_ProbandoLibreriasdeTarea.Properties.Resources.circulo_cromatico;
            this.pictureBox1.Location = new System.Drawing.Point(12, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(73, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "OPERACIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.TextBox txbNumeroInicial;
        private System.Windows.Forms.TextBox txbNumeroFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.Label lblAleatorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

