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
        
        private readonly AcademiaRepositorio repo;
        private readonly Profesor profesor;

        
        public ActualizarProfesor()
        {
            InitializeComponent();
        }

        public ActualizarProfesor(AcademiaRepositorio repo, Profesor profesor) : this()
        {
            this.repo = repo;
            this.profesor = profesor;

            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtTelefono.Text = profesor.Telefono;
            txtEmail.Text = profesor.Email;
            cmbEspecialidad.Text = profesor.Especialidad;
            txtTarifa.Text = profesor.TarifaHora.ToString();
            chkActivo.Checked = profesor.Activo;
        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        
        private bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Apellido obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(cmbEspecialidad.Text))
            {
                MessageBox.Show("Especialidad obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            
            decimal tarifaValidada;
            if (string.IsNullOrWhiteSpace(txtTarifa.Text) || !decimal.TryParse(txtTarifa.Text, out tarifaValidada))
            {
                MessageBox.Show("La tarifa debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (!Validar()) return;

            
            profesor.Nombre = txtNombre.Text.Trim();
            profesor.Apellido = txtApellido.Text.Trim();
            profesor.Telefono = txtTelefono.Text.Trim();
            profesor.Email = txtEmail.Text.Trim();
            profesor.Especialidad = cmbEspecialidad.Text.Trim();
            profesor.TarifaHora = decimal.Parse(txtTarifa.Text.Trim());
            profesor.Activo = chkActivo.Checked;

            repo.ActualizarProfesor(profesor);

            
            MessageBox.Show("Profesor actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}