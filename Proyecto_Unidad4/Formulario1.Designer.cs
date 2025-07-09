namespace Proyecto_Unidad4
{
    partial class Formulario1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblOcupacio = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.tbOcupacion = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbComentarios = new System.Windows.Forms.TextBox();
            this.tbFechaNacimiento = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(35, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(95, 25);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(402, 33);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(102, 25);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(402, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(42, 160);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(86, 25);
            this.lblCedula.TabIndex = 4;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(402, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(108, 25);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(785, 33);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(67, 25);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(785, 97);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(221, 25);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblOcupacio
            // 
            this.lblOcupacio.AutoSize = true;
            this.lblOcupacio.Location = new System.Drawing.Point(785, 160);
            this.lblOcupacio.Name = "lblOcupacio";
            this.lblOcupacio.Size = new System.Drawing.Size(121, 25);
            this.lblOcupacio.TabIndex = 8;
            this.lblOcupacio.Text = "Ocupacion:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(1187, 33);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(143, 25);
            this.lblNacionalidad.TabIndex = 9;
            this.lblNacionalidad.Text = "Nacionalidad:";
            this.lblNacionalidad.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(1187, 97);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(132, 25);
            this.lblEstadoCivil.TabIndex = 10;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(1187, 160);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(139, 25);
            this.lblComentarios.TabIndex = 11;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(147, 30);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(249, 40);
            this.tbNombre.TabIndex = 12;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(147, 160);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 31);
            this.tbCedula.TabIndex = 13;
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(1336, 27);
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.Size = new System.Drawing.Size(100, 31);
            this.tbNacionalidad.TabIndex = 14;
            // 
            // tbOcupacion
            // 
            this.tbOcupacion.Location = new System.Drawing.Point(912, 154);
            this.tbOcupacion.Name = "tbOcupacion";
            this.tbOcupacion.Size = new System.Drawing.Size(100, 31);
            this.tbOcupacion.TabIndex = 15;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(516, 154);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 31);
            this.tbDireccion.TabIndex = 16;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(858, 27);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(100, 31);
            this.tbSexo.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(510, 91);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 31);
            this.tbEmail.TabIndex = 18;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(510, 27);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 31);
            this.tbTelefono.TabIndex = 19;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(147, 91);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 31);
            this.tbApellido.TabIndex = 20;
            // 
            // tbComentarios
            // 
            this.tbComentarios.Location = new System.Drawing.Point(1325, 154);
            this.tbComentarios.Name = "tbComentarios";
            this.tbComentarios.Size = new System.Drawing.Size(100, 31);
            this.tbComentarios.TabIndex = 22;
            // 
            // tbFechaNacimiento
            // 
            this.tbFechaNacimiento.Location = new System.Drawing.Point(1012, 91);
            this.tbFechaNacimiento.Name = "tbFechaNacimiento";
            this.tbFechaNacimiento.Size = new System.Drawing.Size(100, 31);
            this.tbFechaNacimiento.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(58, 223);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(233, 71);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(97, 354);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 82;
            this.dgvRegistros.RowTemplate.Height = 33;
            this.dgvRegistros.Size = new System.Drawing.Size(1295, 276);
            this.dgvRegistros.TabIndex = 25;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(1325, 91);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(152, 33);
            this.cmbEstadoCivil.TabIndex = 26;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 685);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbFechaNacimiento);
            this.Controls.Add(this.tbComentarios);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbOcupacion);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblOcupacio);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Formulario1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblOcupacio;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.TextBox tbOcupacion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbComentarios;
        private System.Windows.Forms.TextBox tbFechaNacimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
    }
}