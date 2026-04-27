using GestiondeAcademiadeMusica.Forms.Alumnos;

namespace GestiondeAcademiadeMusica.Forms
{
    public partial class Uc_Alumnos : UserControl
    {
        private AcademiaRepositorio repo;

        public Uc_Alumnos(AcademiaRepositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
            dgvAlumnos.AllowUserToAddRows = false;
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = repo.Alumnos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAlumno = new AgregarAlumno(repo);
            formAlumno.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null || dgvAlumnos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un alumno para eliminar.", "Aviso");
                return;
            }
            Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            var confirmacion = MessageBox.Show($"¿Estas seguro de eliminar al alumno {alumnoSeleccionado.Nombre} {alumnoSeleccionado.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                repo.EliminarAlumno(alumnoSeleccionado.IdAlumno);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null || dgvAlumnos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un alumno para editar.", "Aviso");
                return;
            }
            Alumno seleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            var form = new ActulizarAlumno(repo, seleccionado);
            form.ShowDialog();
            cargarDatos();
        }
    }
}