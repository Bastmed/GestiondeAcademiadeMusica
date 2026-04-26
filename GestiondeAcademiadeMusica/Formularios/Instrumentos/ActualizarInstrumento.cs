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

namespace GestiondeAcademiadeMusica.Forms.Instrumentos
{
    public partial class ActualizarInstrumento : Form
    {
        private readonly AcademiaRepositorio repo;
        private readonly Instrumento instrumento;
        public ActualizarInstrumento()
        {
            InitializeComponent();
        }
        public ActualizarInstrumento(AcademiaRepositorio repo, Instrumento instrumento) : this()
        {
            this.repo = repo;
            this.instrumento = instrumento;

            txtNombreInstrumento.Text = instrumento.Nombre;
            txtMarcaInstrumento.Text = instrumento.Marca;
            cmbCategoriaInstrumento.SelectedItem = instrumento.Categoria;
            numPrecioInstrumento.Value = instrumento.PrecioMensual;
            cmbEstadoInstrumento.SelectedItem = instrumento.Estado;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            instrumento.Nombre = txtNombreInstrumento.Text.Trim();
            instrumento.Marca = txtMarcaInstrumento.Text.Trim();
            instrumento.Categoria = cmbCategoriaInstrumento.SelectedItem.ToString();
            instrumento.PrecioMensual = numPrecioInstrumento.Value;
            instrumento.Estado = cmbEstadoInstrumento.SelectedItem.ToString();

            repo.ActualizarInstrumento(instrumento);
            MessageBox.Show("Instrumento actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
