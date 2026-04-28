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
            cmbEstadoInstrumento.SelectedItem = instrumento.Estado;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            instrumento.Nombre = txtNombreInstrumento.Text.Trim();
            instrumento.Marca = txtMarcaInstrumento.Text.Trim();
            instrumento.Categoria = cmbCategoriaInstrumento.SelectedItem.ToString();
            instrumento.Estado = cmbEstadoInstrumento.SelectedItem.ToString();

            repo.ActualizarInstrumento(instrumento);
            MessageBox.Show("Instrumento actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}