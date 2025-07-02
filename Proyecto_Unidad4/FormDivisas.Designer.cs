namespace Proyecto_Unidad4
{
    partial class FormDivisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDivisas));
            this.lblCantidadInicial = new System.Windows.Forms.Label();
            this.tbCantidadInicial = new System.Windows.Forms.TextBox();
            this.lblMOrigen = new System.Windows.Forms.Label();
            this.cmbMOrigen = new System.Windows.Forms.ComboBox();
            this.lblMDestino = new System.Windows.Forms.Label();
            this.cmbMDestino = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCantidadInicial
            // 
            this.lblCantidadInicial.AutoSize = true;
            this.lblCantidadInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadInicial.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInicial.Location = new System.Drawing.Point(37, 223);
            this.lblCantidadInicial.Name = "lblCantidadInicial";
            this.lblCantidadInicial.Size = new System.Drawing.Size(297, 33);
            this.lblCantidadInicial.TabIndex = 0;
            this.lblCantidadInicial.Text = "Cantidad a convertir: ";
            // 
            // tbCantidadInicial
            // 
            this.tbCantidadInicial.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadInicial.Location = new System.Drawing.Point(371, 216);
            this.tbCantidadInicial.Name = "tbCantidadInicial";
            this.tbCantidadInicial.Size = new System.Drawing.Size(322, 40);
            this.tbCantidadInicial.TabIndex = 1;
            // 
            // lblMOrigen
            // 
            this.lblMOrigen.AutoSize = true;
            this.lblMOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblMOrigen.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOrigen.Location = new System.Drawing.Point(37, 275);
            this.lblMOrigen.Name = "lblMOrigen";
            this.lblMOrigen.Size = new System.Drawing.Size(256, 33);
            this.lblMOrigen.TabIndex = 2;
            this.lblMOrigen.Text = "Moneda de origen: ";
            // 
            // cmbMOrigen
            // 
            this.cmbMOrigen.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMOrigen.FormattingEnabled = true;
            this.cmbMOrigen.Location = new System.Drawing.Point(371, 267);
            this.cmbMOrigen.Name = "cmbMOrigen";
            this.cmbMOrigen.Size = new System.Drawing.Size(222, 41);
            this.cmbMOrigen.TabIndex = 3;
            // 
            // lblMDestino
            // 
            this.lblMDestino.AutoSize = true;
            this.lblMDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblMDestino.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDestino.Location = new System.Drawing.Point(37, 328);
            this.lblMDestino.Name = "lblMDestino";
            this.lblMDestino.Size = new System.Drawing.Size(276, 33);
            this.lblMDestino.TabIndex = 4;
            this.lblMDestino.Text = "Moneda a convertir: ";
            // 
            // cmbMDestino
            // 
            this.cmbMDestino.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMDestino.FormattingEnabled = true;
            this.cmbMDestino.Location = new System.Drawing.Point(371, 320);
            this.cmbMDestino.Name = "cmbMDestino";
            this.cmbMDestino.Size = new System.Drawing.Size(219, 41);
            this.cmbMDestino.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(1012, 223);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(45, 33);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "\" \"";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(771, 223);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(158, 33);
            this.labelR.TabIndex = 7;
            this.labelR.Text = "Resultado: ";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConvertir.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(777, 275);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(237, 68);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir ";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 114);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conversor de divisas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbMDestino);
            this.Controls.Add(this.lblMDestino);
            this.Controls.Add(this.cmbMOrigen);
            this.Controls.Add(this.lblMOrigen);
            this.Controls.Add(this.tbCantidadInicial);
            this.Controls.Add(this.lblCantidadInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDivisas";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadInicial;
        private System.Windows.Forms.TextBox tbCantidadInicial;
        private System.Windows.Forms.Label lblMOrigen;
        private System.Windows.Forms.ComboBox cmbMOrigen;
        private System.Windows.Forms.Label lblMDestino;
        private System.Windows.Forms.ComboBox cmbMDestino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
    }
}