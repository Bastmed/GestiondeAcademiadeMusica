using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica.Forms
{
    public partial class AgregarAlumno : Form
    {
        private readonly AcademiaRepositorio repo;
        public Alumno AlumnoActual { get; private set; }
        public AgregarAlumno()
        {
            InitializeComponent();
        }
        public AgregarAlumno(AcademiaRepositorio repo) : this()
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
            AlumnoActual = new Alumno();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            {
                if (!Validar()) return;
                AlumnoActual.Nombre = txtNombreAlumno.Text.Trim();
                AlumnoActual.Apellido = txtApellidoAlumno.Text.Trim();
                AlumnoActual.FechaNacimiento = dtpFechaAlumno.Value.Date;
                AlumnoActual.Telefono = txtTelefonoAlumno.Text.Trim();
                AlumnoActual.Email = txtEmailAlumno.Text.Trim();
                AlumnoActual.Activo = chkActivoAlumno.Checked;
                repo.AgregarAlumno(AlumnoActual);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
