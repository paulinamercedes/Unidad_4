namespace Proyecto_Unidad4
{
    partial class FormImpuestos
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
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.lblMontoFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(165, 249);
            this.tbMonto.Multiline = true;
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(300, 43);
            this.tbMonto.TabIndex = 0;
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(513, 249);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(321, 41);
            this.cmbImpuesto.TabIndex = 1;
            this.cmbImpuesto.SelectedIndexChanged += new System.EventHandler(this.cmbImpuesto_SelectedIndexChanged);
            // 
            // lblMontoFinal
            // 
            this.lblMontoFinal.AutoSize = true;
            this.lblMontoFinal.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoFinal.Location = new System.Drawing.Point(159, 323);
            this.lblMontoFinal.Name = "lblMontoFinal";
            this.lblMontoFinal.Size = new System.Drawing.Size(180, 33);
            this.lblMontoFinal.TabIndex = 2;
            this.lblMontoFinal.Text = "Monto Final:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Plum;
            this.btnCalcular.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(292, 412);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 68);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Impuesto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(576, 412);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 68);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calculo de Impuestos";
            // 
            // FormImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1058, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMontoFinal);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.tbMonto);
            this.Name = "FormImpuestos";
            this.Text = "FormImpuestos";
            this.Load += new System.EventHandler(this.FormImpuestos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        private System.Windows.Forms.Label lblMontoFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
    }
}