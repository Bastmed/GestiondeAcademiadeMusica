using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeAcademiadeMusica.Forms.Profesores; 
namespace GestiondeAcademiadeMusica.Forms.UserControls
{
    public partial class Uc_Profesores : UserControl
    {

        private AcademiaRepositorio _repositorio;

        public Uc_Profesores()
        {
            InitializeComponent();
        }


        public void Inicializar(AcademiaRepositorio repo)
        {
            _repositorio = repo;


            dgvProfesores.DataSource = _repositorio.Profesores;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (_repositorio != null)
            {

                AgregarProfesor ventanaAgregar = new AgregarProfesor(_repositorio);
                ventanaAgregar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: El sistema de datos no está inicializado.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvProfesores.SelectedRows.Count > 0)
            {

                Profesor profesorSeleccionado = (Profesor)dgvProfesores.SelectedRows[0].DataBoundItem;


                DialogResult respuesta = MessageBox.Show(
                    $"¿Estás seguro de eliminar al profesor {profesorSeleccionado.Nombre} {profesorSeleccionado.Apellido}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    _repositorio.EliminarProfesor(profesorSeleccionado.IdProfesor);
                    MessageBox.Show("Profesor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor de la tabla para eliminarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                
                Profesor profesorSeleccionado = (Profesor)dgvProfesores.SelectedRows[0].DataBoundItem;

                
                ActualizarProfesor ventanaActualizar = new ActualizarProfesor(_repositorio, profesorSeleccionado);
                ventanaActualizar.ShowDialog();

                
                dgvProfesores.Refresh();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesor de la tabla para actualizar sus datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}