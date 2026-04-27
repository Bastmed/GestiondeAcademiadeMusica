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
    public partial class ActualizarProfesor : Form
    {
        private AcademiaRepositorio _repositorio;
        private Profesor _profesorAEditar;

        
        public ActualizarProfesor(AcademiaRepositorio repo, Profesor profesor)
        {
            InitializeComponent();
            _repositorio = repo;
            _profesorAEditar = profesor;

            
            txtNombre.Text = _profesorAEditar.Nombre;
            txtApellido.Text = _profesorAEditar.Apellido;
            txtTelefono.Text = _profesorAEditar.Telefono;
            txtEmail.Text = _profesorAEditar.Email;
            cmbEspecialidad.Text = _profesorAEditar.Especialidad;
            txtTarifa.Text = _profesorAEditar.TarifaHora.ToString();
            chkActivo.Checked = _profesorAEditar.Activo;
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
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

            
            _profesorAEditar.Nombre = txtNombre.Text;
            _profesorAEditar.Apellido = txtApellido.Text;
            _profesorAEditar.Telefono = txtTelefono.Text;
            _profesorAEditar.Email = txtEmail.Text;
            _profesorAEditar.Especialidad = cmbEspecialidad.Text;
            _profesorAEditar.TarifaHora = tarifaValidada;
            _profesorAEditar.Activo = chkActivo.Checked;

            
            _repositorio.ActualizarProfesor(_profesorAEditar);

            MessageBox.Show("¡Profesor actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}