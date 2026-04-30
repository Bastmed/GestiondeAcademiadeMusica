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
    public partial class ActualizarAlumno : Form
    {
        private readonly AcademiaRepositorio repo;
        private readonly Alumno alumno;

        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        public ActualizarAlumno(AcademiaRepositorio repo, Alumno alumno) : this()
        {
            this.repo = repo;
            this.alumno = alumno;

            cmbInstrumento.DisplayMember = "Nombre";
            cmbInstrumento.DataSource = repo.Instrumentos;

            var instrumentoActual = repo.Instrumentos.FirstOrDefault(x => x.IdInstrumento == alumno.IdInstrumento);
            if (instrumentoActual != null)
                cmbInstrumento.SelectedItem = instrumentoActual;

            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoAlumno.Text = alumno.Apellido;
            txtTelefonoAlumno.Text = alumno.Telefono;
            txtEmailAlumno.Text = alumno.Email;
            dtpFechaAlumno.Value = alumno.FechaNacimiento;
            chkActivoAlumno.Checked = alumno.Activo;
        }

        private bool Validar()
        {
            var errores = new List<string>();
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text))
            {
                errores.Add("Nombre obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                errores.Add("Apellido obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtTelefonoAlumno.Text))
            {
                errores.Add("Teléfono obligatorio");
            }
            if (string.IsNullOrWhiteSpace(txtEmailAlumno.Text))
            {
                errores.Add("Email obligatorio");
            }
            if (cmbInstrumento.SelectedIndex == -1)
            {
                errores.Add("Instrumento obligatorio");
            }

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

            var instrumentoSeleccionado = (Instrumento)cmbInstrumento.SelectedItem;

            alumno.Nombre = txtNombreAlumno.Text.Trim();
            alumno.Apellido = txtApellidoAlumno.Text.Trim();
            alumno.Telefono = txtTelefonoAlumno.Text.Trim();
            alumno.Email = txtEmailAlumno.Text.Trim();
            alumno.FechaNacimiento = dtpFechaAlumno.Value.Date;
            alumno.Activo = chkActivoAlumno.Checked;
            alumno.IdInstrumento = instrumentoSeleccionado.IdInstrumento;
            alumno.NombreInstrumento = instrumentoSeleccionado.Nombre;

            repo.ActualizarAlumno(alumno);

            MessageBox.Show("Alumno actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}