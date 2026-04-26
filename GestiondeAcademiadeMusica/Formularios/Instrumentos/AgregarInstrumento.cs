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
    public partial class AgregarInstrumento : Form
    {
        private readonly AcademiaRepositorio repo;
        public Instrumento InstrumentoActual { get; private set; }
        public AgregarInstrumento()
        {
            InitializeComponent();
        }
        public AgregarInstrumento(AcademiaRepositorio repo) : this()
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
            InstrumentoActual = new Instrumento();
        }
        private bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtNombreInstrumento.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtMarcaInstrumento.Text))
            {
                MessageBox.Show("Marca obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (cmbCategoriaInstrumento.SelectedIndex == -1)
            {
                MessageBox.Show("Categoría obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (numPrecioInstrumento.Value <= 0)
            {
                MessageBox.Show("Precio obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (cmbEstadoInstrumento.SelectedIndex == -1)
            {
                MessageBox.Show("Estado obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            return ok;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            InstrumentoActual.Nombre = txtNombreInstrumento.Text.Trim();
            InstrumentoActual.Marca = txtMarcaInstrumento.Text.Trim();
            InstrumentoActual.Categoria = cmbCategoriaInstrumento.SelectedItem.ToString();
            InstrumentoActual.PrecioMensual = numPrecioInstrumento.Value;
            InstrumentoActual.Estado = cmbEstadoInstrumento.SelectedItem.ToString();
            repo.AgregarInstrumento(InstrumentoActual);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
