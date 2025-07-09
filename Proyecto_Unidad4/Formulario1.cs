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
            dgvRegistros.Columns[11].Name = "Comentarios";
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear arreglo con los valores de los TextBox
            string[] fila = new string[]
            {
                tbNombre.Text,
                tbApellido.Text,
                tbCedula.Text,
                tbTelefono.Text,
                tbEmail.Text,
                tbDireccion.Text,
                tbSexo.Text,
                tbFechaNacimiento.Text,
                tbOcupacion.Text,
                tbNacionalidad.Text,
                tbComentarios.Text,

                //aqui la combo box 
                 cmbEstadoCivil.SelectedItem.ToString(),
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
            tbSexo.Clear();
            tbFechaNacimiento.Clear();
            tbOcupacion.Clear();
            tbNacionalidad.Clear();
            cmbEstadoCivil.SelectedIndex = 0;
            tbComentarios.Clear();
        }


    }
}
