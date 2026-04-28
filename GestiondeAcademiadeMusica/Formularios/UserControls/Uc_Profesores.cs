using GestiondeAcademiadeMusica.Forms.Profesores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica.Forms.UserControls
{
    public partial class Uc_Profesores : UserControl
    {
        private AcademiaRepositorio repo;

        public Uc_Profesores(AcademiaRepositorio repo)
        {
            InitializeComponent();
            this.repo = repo;

            dgvProfesores.AllowUserToAddRows = false;
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvProfesores.DataSource = null;
            dgvProfesores.DataSource = repo.Profesores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProfesor = new AgregarProfesor(repo);
            formProfesor.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvProfesores.CurrentRow == null || dgvProfesores.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un profesor para eliminar.", "Aviso");
                return;
            }

            Profesor profesorSeleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            var confirmacion = MessageBox.Show($"¿Estas seguro de eliminar al profesor {profesorSeleccionado.Nombre} {profesorSeleccionado.Apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                repo.EliminarProfesor(profesorSeleccionado.IdProfesor);
                cargarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.CurrentRow == null || dgvProfesores.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un profesor para editar.", "Aviso");
                return;
            }

            Profesor seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            var form = new ActualizarProfesor(repo, seleccionado);
            form.ShowDialog();
            cargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                dgvProfesores.DataSource = null;
                dgvProfesores.DataSource = repo.Profesores;
            }
            else
            {
                var resultado = repo.Profesores.Where(profesor => profesor.Nombre.ToLower().Contains(filtro)).ToList();
                dgvProfesores.DataSource = null;
                dgvProfesores.DataSource = resultado;
            }
        }
    }
}