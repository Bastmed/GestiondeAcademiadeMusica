using GestiondeAcademiadeMusica.Forms.Alumnos;
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
    public partial class Uc_Alumnos : UserControl
    {
        private AcademiaRepositorio repo;
        public Uc_Alumnos(AcademiaRepositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
            cargarDatos();

        }

        private void Uc_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAlumno = new AgregarAlumno(repo);
            formAlumno.Show();
            cargarDatos();
        }
        private void cargarDatos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = repo.Alumnos;
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
