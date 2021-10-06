
namespace U1_Topicos_Mas_Componentes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCarreras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chlbGeneros = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbSeries = new System.Windows.Forms.CheckBox();
            this.chbPeliculas = new System.Windows.Forms.CheckBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.DGVregistros = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeliculasSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVregistros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbEstadoCivil);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbCarreras);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chlbGeneros);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chbSeries);
            this.panel1.Controls.Add(this.chbPeliculas);
            this.panel1.Controls.Add(this.rbtFemenino);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbContraseña);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbCorreo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 864);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 656);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Estado civil:\r\n";
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.FormattingEnabled = true;
            this.lbEstadoCivil.ItemHeight = 25;
            this.lbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo"});
            this.lbEstadoCivil.Location = new System.Drawing.Point(130, 627);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(300, 79);
            this.lbEstadoCivil.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha\r\nde nacimiento\r\n";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(140, 548);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(300, 31);
            this.dtpFechaNacimiento.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Carreras:";
            // 
            // cbCarreras
            // 
            this.cbCarreras.FormattingEnabled = true;
            this.cbCarreras.Items.AddRange(new object[] {
            "Ingenieria Electromecanica",
            "Ingenieria en Energia Renovables",
            "Ingenieria en Gestion Empresarial",
            "Ingenieria Industrial",
            "Ingenieria en Sistemas Computacionales",
            "",
            ""});
            this.cbCarreras.Location = new System.Drawing.Point(142, 495);
            this.cbCarreras.Name = "cbCarreras";
            this.cbCarreras.Size = new System.Drawing.Size(300, 33);
            this.cbCarreras.TabIndex = 17;
            this.cbCarreras.Text = "Selecciona tu carrera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Generos:";
            // 
            // chlbGeneros
            // 
            this.chlbGeneros.FormattingEnabled = true;
            this.chlbGeneros.Items.AddRange(new object[] {
            "Acción",
            "Aventuras",
            "Ciencia Ficción",
            "Comedia",
            "Documental",
            "Drama",
            "Fantasia",
            "Musical",
            "Suspenso",
            "Terror"});
            this.chlbGeneros.Location = new System.Drawing.Point(108, 332);
            this.chlbGeneros.Name = "chlbGeneros";
            this.chlbGeneros.Size = new System.Drawing.Size(334, 144);
            this.chlbGeneros.TabIndex = 15;
            this.chlbGeneros.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "¿Peliculas \r\no Series?";
            // 
            // chbSeries
            // 
            this.chbSeries.AutoSize = true;
            this.chbSeries.Location = new System.Drawing.Point(327, 271);
            this.chbSeries.Name = "chbSeries";
            this.chbSeries.Size = new System.Drawing.Size(84, 29);
            this.chbSeries.TabIndex = 13;
            this.chbSeries.Text = "Series";
            this.chbSeries.UseVisualStyleBackColor = true;
            // 
            // chbPeliculas
            // 
            this.chbPeliculas.AutoSize = true;
            this.chbPeliculas.Location = new System.Drawing.Point(124, 271);
            this.chbPeliculas.Name = "chbPeliculas";
            this.chbPeliculas.Size = new System.Drawing.Size(107, 29);
            this.chbPeliculas.TabIndex = 12;
            this.chbPeliculas.Text = "Pelilculas";
            this.chbPeliculas.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(327, 236);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(115, 29);
            this.rbtFemenino.TabIndex = 11;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sexo";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(124, 192);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.PlaceholderText = "ingresa tu contraseña";
            this.txbContraseña.Size = new System.Drawing.Size(318, 31);
            this.txbContraseña.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña";
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(124, 145);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.PlaceholderText = "ingresa tu correo electronico";
            this.txbCorreo.Size = new System.Drawing.Size(318, 31);
            this.txbCorreo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo:";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(124, 101);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PlaceholderText = "ingresa tu apellido";
            this.txbApellido.Size = new System.Drawing.Size(318, 31);
            this.txbApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "ingresa tu nombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de Registro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.DGVregistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(474, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1287, 864);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Registro";
            // 
            // DGVregistros
            // 
            this.DGVregistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVregistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Email,
            this.Contraseña,
            this.PeliculasSeries,
            this.Genero,
            this.Carrera,
            this.FechaNacimiento,
            this.Nacimiento,
            this.EdoCivil});
            this.DGVregistros.Location = new System.Drawing.Point(37, 52);
            this.DGVregistros.Name = "DGVregistros";
            this.DGVregistros.RowHeadersWidth = 62;
            this.DGVregistros.RowTemplate.Height = 33;
            this.DGVregistros.Size = new System.Drawing.Size(1250, 563);
            this.DGVregistros.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre(s)";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Correo";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 8;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Width = 150;
            // 
            // PeliculasSeries
            // 
            this.PeliculasSeries.HeaderText = "Sexo";
            this.PeliculasSeries.MinimumWidth = 8;
            this.PeliculasSeries.Name = "PeliculasSeries";
            this.PeliculasSeries.Width = 150;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "PeliculasSeries";
            this.Genero.MinimumWidth = 8;
            this.Genero.Name = "Genero";
            this.Genero.Width = 150;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Genero";
            this.Carrera.MinimumWidth = 8;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 150;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Carrera";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 150;
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Fecha Naciemento";
            this.Nacimiento.MinimumWidth = 8;
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.Width = 150;
            // 
            // EdoCivil
            // 
            this.EdoCivil.HeaderText = "Estado civil";
            this.EdoCivil.MinimumWidth = 8;
            this.EdoCivil.Name = "EdoCivil";
            this.EdoCivil.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 864);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVregistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox chlbGeneros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbSeries;
        private System.Windows.Forms.CheckBox chbPeliculas;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCarreras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbEstadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGVregistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeliculasSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdoCivil;
    }
}

