using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Unidad4
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int Limite;


            //validacion del numero ingresado 
            if (!int.TryParse(tbLimite.Text, out Limite) || Limite < 0)
            {
                MessageBox.Show("Favor de ingresar un numero entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            tbResultado.Clear(); //para limpiar

            int a = 0, b = 1;

            tbResultado.AppendText(" La seri Fibonacci es hasta " + Limite + ":\r\n");

            while (a <= Limite)
            {
                tbResultado.AppendText(a + "\r\n");   //para que  cada nmero este en una linea 
                int temp = a + b; a = b; b = temp;
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbResultado.Text) && string.IsNullOrWhiteSpace(tbLimite.Text))
            {

                MessageBox.Show("La caja de texto ya está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else

            {
                tbResultado.Clear();
                tbLimite.Clear();
            }
        }
    }
}
