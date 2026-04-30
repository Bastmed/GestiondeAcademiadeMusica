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
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNombreInstrumento.Text))
                errores.Add("Nombre obligatorio");

            if (string.IsNullOrWhiteSpace(txtMarcaInstrumento.Text))
                errores.Add("Marca obligatoria");

            if (cmbCategoriaInstrumento.SelectedIndex == -1)
                errores.Add("Categoría obligatoria");

            if (cmbEstadoInstrumento.SelectedIndex == -1)
                errores.Add("Estado obligatorio");

            if (errores.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, errores), "Error: Ingresa los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            InstrumentoActual.Nombre = txtNombreInstrumento.Text.Trim();
            InstrumentoActual.Marca = txtMarcaInstrumento.Text.Trim();
            InstrumentoActual.Categoria = cmbCategoriaInstrumento.SelectedItem.ToString();
            InstrumentoActual.Estado = cmbEstadoInstrumento.SelectedItem.ToString();
            repo.AgregarInstrumento(InstrumentoActual);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}