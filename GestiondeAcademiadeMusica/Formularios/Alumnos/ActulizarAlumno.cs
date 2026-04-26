using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica.Forms.Alumnos
{
    public partial class ActulizarAlumno : Form
    {
        private readonly AcademiaRepositorio repo;
        private readonly Alumno alumno;
        public ActulizarAlumno()
        {
            InitializeComponent();
        }
        public ActulizarAlumno(AcademiaRepositorio repo, Alumno alumno) : this()
        {
            this.repo = repo;
            this.alumno = alumno;

            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoAlumno.Text = alumno.Apellido;
            txtTelefonoAlumno.Text = alumno.Telefono;
            txtEmailAlumno.Text = alumno.Email;
            dtpFechaAlumno.Value = alumno.FechaNacimiento;
            chkActivoAlumno.Checked = alumno.Activo;
        }
        private bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("Apellido obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (!string.IsNullOrWhiteSpace(txtEmailAlumno.Text) && !txtEmailAlumno.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            return ok;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            alumno.Nombre = txtNombreAlumno.Text.Trim();
            alumno.Apellido = txtApellidoAlumno.Text.Trim();
            alumno.Telefono = txtTelefonoAlumno.Text.Trim();
            alumno.Email = txtEmailAlumno.Text.Trim();
            alumno.FechaNacimiento = dtpFechaAlumno.Value.Date;
            alumno.Activo = chkActivoAlumno.Checked;

            repo.ActualizarAlumno(alumno);

            MessageBox.Show("Alumno actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
