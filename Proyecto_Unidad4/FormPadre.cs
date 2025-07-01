using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Unidad4;

namespace Proyecto_Unidad4
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
            this.IsMdiContainer = true;   //indica que es un container
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                    
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario1 f1 = new Formulario1();
            f1.MdiParent = this; f1.Show();

        }

        private void conversorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDivisas fD = new FormDivisas();
            fD.MdiParent = this; fD.Show();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImpuestos fI = new FormImpuestos();
            fI.MdiParent = this; fI.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci fF = new FormFibonacci();
            fF.MdiParent = this;  fF.Show();
        }
    }
}
