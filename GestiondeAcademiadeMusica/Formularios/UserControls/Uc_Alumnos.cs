using GestiondeAcademiadeMusica.Forms.Alumnos;
using System.Linq;

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

            // Mostrar el nombre del instrumento en vez del ID
            idInstrumentoDataGridViewTextBoxColumn.DataPropertyName = "NombreInstrumento";
            idInstrumentoDataGridViewTextBoxColumn.HeaderText = "Instrumento";

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
                repo.EliminarAlumno(alumnoSeleccionado.IdAlumno);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null || dgvAlumnos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un alumno para editar.", "Aviso");
                return;
            }
            Alumno seleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            var form = new ActualizarAlumno(repo, seleccionado);
            form.ShowDialog();
            cargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = repo.Alumnos;
            }
            else
            {
                var resultado = repo.Alumnos.Where(alumno => alumno.Nombre.ToLower().Contains(filtro)).ToList();
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = resultado;
            }
        }

    }
}