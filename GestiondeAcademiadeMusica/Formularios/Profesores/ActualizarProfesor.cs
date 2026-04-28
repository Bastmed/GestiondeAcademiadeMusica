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

        private bool Validar()
        {
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.Add("Nombre obligatorio");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
                errores.Add("Apellido obligatorio");

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
                errores.Add("Email inválido");

            if (string.IsNullOrWhiteSpace(cmbEspecialidad.Text))
                errores.Add("Especialidad obligatoria");

            if (!decimal.TryParse(txtTarifa.Text.Trim(), out decimal tarifa) || tarifa <= 0)
                errores.Add("Tarifa por hora inválida (debe ser un número mayor a 0)");

            if (errores.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, errores), "Error: Ingresa los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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