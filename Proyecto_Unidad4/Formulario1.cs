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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();

            // Configurar columnas del DataGridView
            dgvRegistros.ColumnCount = 12;
            dgvRegistros.Columns[0].Name = "Nombre";
            dgvRegistros.Columns[1].Name = "Apellido";
            dgvRegistros.Columns[2].Name = "Cédula";
            dgvRegistros.Columns[3].Name = "Teléfono";
            dgvRegistros.Columns[4].Name = "Email";
            dgvRegistros.Columns[5].Name = "Dirección";
            dgvRegistros.Columns[6].Name = "Sexo";
            dgvRegistros.Columns[7].Name = "Fecha Nac.";
            dgvRegistros.Columns[8].Name = "Ocupación";
            dgvRegistros.Columns[9].Name = "Nacionalidad";
            dgvRegistros.Columns[10].Name = "Estado civil";
            dgvRegistros.Columns[11].Name = "Nivel Educativo";
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            // Contenidos de las comboBox
            cmbEstadoCivil.Items.AddRange(new string[] { "Soltera(o)", "Casada(o)", "Divorciada(o)", "Viuda(o)" });
            cmbSexo.Items.AddRange(new string[] { "M", "F" });
            cmbNivelEducativo.Items.AddRange(new string[] { "Primaria", "Secundaria", "Universitario", "PostGrado", "Doctorado", "Técnico" });

            //Selecciona 0 por defecto
            cmbEstadoCivil.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
            cmbNivelEducativo.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // verificacion de que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            
            string[] fila = new string[]
            {
                tbNombre.Text,
                tbApellido.Text,
                tbCedula.Text,
                tbTelefono.Text,
                tbEmail.Text,
                tbDireccion.Text,
                cmbSexo.SelectedItem?.ToString() ?? "",
                tbFechaNacimiento.Text,
                tbOcupacion.Text,
                tbNacionalidad.Text,
                cmbEstadoCivil.SelectedItem?.ToString() ?? "",
                cmbNivelEducativo.SelectedItem?.ToString() ?? ""
            };

            // Agregar la fila al DataGridView
            dgvRegistros.Rows.Add(fila);

            // Limpiar campos
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbCedula.Clear();
            tbTelefono.Clear();
            tbEmail.Clear();
            tbDireccion.Clear();
            tbFechaNacimiento.Clear();
            tbOcupacion.Clear();
            tbNacionalidad.Clear();

            cmbEstadoCivil.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
            cmbNivelEducativo.SelectedIndex = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
        {
            if (dgvRegistros.SelectedRows.Count > 0)
            {
                // Confirmacion antes de eliminar el registro
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvRegistros.Rows.RemoveAt(dgvRegistros.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNivelEducativo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComentarios_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoCivil_Click(object sender, EventArgs e)
        {

        }

        private void tbOcupacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


