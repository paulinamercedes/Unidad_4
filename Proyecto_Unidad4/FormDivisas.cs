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
    public partial class FormDivisas : Form
    {
        public FormDivisas()
        {
            InitializeComponent();

            //Monedas de las ComboBox
            cmbMOrigen.Items.AddRange(new string[] { "Dólar", "Euro", "Peso Dominicano" });
            cmbMDestino.Items.AddRange(new string[] { "Dólar", "Euro", "Peso Dominicano" });
            cmbMOrigen.SelectedIndex = 0;
            cmbMDestino.SelectedIndex = 1;


        }
      

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (!double.TryParse(tbCantidadInicial.Text, out cantidad))
            {
                MessageBox.Show("Ingresar un valos valido");
                return;
            }

            string origen = cmbMOrigen.SelectedItem.ToString();
            string destino = cmbMDestino.SelectedItem.ToString();

            double valorEnDolares = 0;


            // Convertir desde moneda origen a dólares (para mayor facilidad)
            switch (origen)
            {
                case "Dólar":
                    valorEnDolares = cantidad;
                    break;
                case "Euro":
                    valorEnDolares = cantidad * 1.1; // 1 euro son 1.1 dólares
                    break;
                case "Peso Dominicano":
                    valorEnDolares = cantidad / 58.0; // 1 dólar son 58 pesos
                    break;
            }

            double resultado = 0;

            // Convertir desde dólares a moneda destino
            switch (destino)
            {
                case "Dólar":
                    resultado = valorEnDolares;
                    break;
                case "Euro":
                    resultado = valorEnDolares / 1.1;
                    break;
                case "Peso Dominicano":
                    resultado = valorEnDolares * 58.0;
                    break;
            }

            lblResultado.Text = $"Resultado: {resultado:F2} {destino}";
        }





    }
}
