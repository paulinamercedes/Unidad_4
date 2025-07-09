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
    public partial class FormImpuestos : Form
    {

        public FormImpuestos()
        {
            InitializeComponent();

            cmbImpuesto.Items.AddRange(new string[]
            {
                "18% ITBIS",
                "10% Selectivo al Consumo",
                "5% Impuesto Municipal",
                "0% Exento"
            });

            cmbImpuesto.SelectedIndex = 0;
        }

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
            {
                double monto;

                // Validar monto
                if (!double.TryParse(tbMonto.Text, out monto) || monto < 0)
                {
                    MessageBox.Show("Ingrese un monto válido.");
                    return;
                }

                string tipoImpuesto = cmbImpuesto.SelectedItem?.ToString();
                double porcentaje = ObtenerPorcentaje(tipoImpuesto);

                double impuesto = monto * porcentaje;
                double total = monto + impuesto;

            lblMontoFinal.Text = "Monto Final: Impuesto: " + impuesto.ToString("F2") + " | Total: " + total.ToString("F2");


        }

        private double ObtenerPorcentaje(string tipo)
        {
            switch (tipo)
            {
                case "18% ITBIS":
                    return 0.18;
                case "10% Selectivo al Consumo":
                    return 0.10;
                case "5% Impuesto Municipal":
                    return 0.05;
                case "0% Exento":
                    return 0.0;
                default:
                    return 0.0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //si los campos estan vacios envia un mensaje

            if (string.IsNullOrWhiteSpace(tbMonto.Text) &&
                cmbImpuesto.SelectedIndex == 0 &&
                lblMontoFinal.Text == "Resultado: "
                )
            {
                MessageBox.Show("No hay datos para borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Para limpiar los campos
            tbMonto.Clear();
            cmbImpuesto.SelectedIndex = 0;
            lblMontoFinal.Text = "Resultado: ";
        }

        private void FormImpuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
