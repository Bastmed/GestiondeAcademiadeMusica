using GestiondeAcademiadeMusica.Forms;
using GestiondeAcademiadeMusica.Forms.Instrumentos;

namespace GestiondeAcademiadeMusica.Forms.UserControls
{
    public partial class Uc_Instrumentos : UserControl
    {
        private AcademiaRepositorio repo;

        public Uc_Instrumentos(AcademiaRepositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvInstrumentos.DataSource = null;
            dgvInstrumentos.DataSource = repo.Instrumentos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formInstrumento = new AgregarInstrumento(repo);
            formInstrumento.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentos.CurrentRow == null || dgvInstrumentos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un instrumento para eliminar.", "Aviso");
                return;
            }
            Instrumento instrumentoSeleccionado = (Instrumento)dgvInstrumentos.CurrentRow.DataBoundItem;
            var confirmacion = MessageBox.Show($"¿Estas seguro de eliminar el instrumento {instrumentoSeleccionado.Nombre} de la marca {instrumentoSeleccionado.Marca}?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                repo.EliminarInstrumento(instrumentoSeleccionado.IdInstrumento);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentos.CurrentRow == null || dgvInstrumentos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un instrumento para editar.", "Aviso");
                return;
            }
            Instrumento seleccionado = (Instrumento)dgvInstrumentos.CurrentRow.DataBoundItem;
            var formActualizar = new ActualizarInstrumento(repo, seleccionado);
            formActualizar.ShowDialog();
            cargarDatos();
        }
    }
}