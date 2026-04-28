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

            cmbInstrumentoAgr.DisplayMember = "Nombre";
            cmbInstrumentoAgr.DataSource = repo.Instrumentos;
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
            if (cmbInstrumentoAgr.SelectedIndex == -1)
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

                var instrumentoSeleccionado = (Instrumento)cmbInstrumentoAgr.SelectedItem;
                AlumnoActual.IdInstrumento = instrumentoSeleccionado.IdInstrumento;
                AlumnoActual.NombreInstrumento = instrumentoSeleccionado.Nombre;

                repo.AgregarAlumno(AlumnoActual);


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
