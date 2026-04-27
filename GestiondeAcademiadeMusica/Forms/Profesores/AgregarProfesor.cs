using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica.Forms.Profesores
{
    public partial class AgregarProfesor : Form
    {
        
        private AcademiaRepositorio _repositorio;

        
        public AgregarProfesor(AcademiaRepositorio repo)
        {
            InitializeComponent();
            _repositorio = repo; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                                              
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbEspecialidad.Text) ||
                string.IsNullOrWhiteSpace(txtTarifa.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tarifaValidada;
            if (!decimal.TryParse(txtTarifa.Text, out tarifaValidada))
            {
                MessageBox.Show("La tarifa debe ser un número válido (ejemplo: 15000 o 15000,50).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Profesor nuevoProfesor = new Profesor
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Especialidad = cmbEspecialidad.Text,
                TarifaHora = tarifaValidada,
                Activo = chkActivo.Checked
            };

            
            _repositorio.AgregarProfesor(nuevoProfesor);

            MessageBox.Show("¡Profesor agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}