namespace Proyecto_Unidad4
{
    partial class FormFibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFibonacci));
            this.lblLimite = new System.Windows.Forms.Label();
            this.tbLimite = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLimite
            // 
            this.lblLimite.BackColor = System.Drawing.Color.Transparent;
            this.lblLimite.Font = new System.Drawing.Font("Century Schoolbook", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(158, 251);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(168, 56);
            this.lblLimite.TabIndex = 0;
            this.lblLimite.Text = "Limite: ";
            this.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLimite
            // 
            this.tbLimite.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLimite.Location = new System.Drawing.Point(359, 261);
            this.tbLimite.Name = "tbLimite";
            this.tbLimite.Size = new System.Drawing.Size(100, 46);
            this.tbLimite.TabIndex = 1;
            this.tbLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.MistyRose;
            this.btnGenerar.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(239, 335);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(187, 87);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.BackColor = System.Drawing.Color.MistyRose;
            this.tbResultado.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(549, 251);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultado.Size = new System.Drawing.Size(387, 171);
            this.tbResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serie Fibonacci";
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tbLimite);
            this.Controls.Add(this.lblLimite);
            this.Name = "FormFibonacci";
            this.Text = "FormFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox tbLimite;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label1;
    }
}