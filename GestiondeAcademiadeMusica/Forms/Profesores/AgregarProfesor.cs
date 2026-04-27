using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica.Forms.Profesores 
{
    public partial class AgregarProfesor : Form
    {
        private readonly AcademiaRepositorio repo;
        public Profesor ProfesorActual { get; private set; }

        public AgregarProfesor()
        {
            InitializeComponent();
        }

        public AgregarProfesor(AcademiaRepositorio repo) : this()
        {
            this.repo = repo ?? throw new ArgumentNullException(nameof(repo));
            ProfesorActual = new Profesor();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Apellido obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(cmbEspecialidad.Text))
            {
                MessageBox.Show("Especialidad obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            decimal tarifaValidada;
            if (string.IsNullOrWhiteSpace(txtTarifa.Text) || !decimal.TryParse(txtTarifa.Text, out tarifaValidada))
            {
                MessageBox.Show("La tarifa debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            ProfesorActual.Nombre = txtNombre.Text.Trim();
            ProfesorActual.Apellido = txtApellido.Text.Trim();
            ProfesorActual.Telefono = txtTelefono.Text.Trim();
            ProfesorActual.Email = txtEmail.Text.Trim();
            ProfesorActual.Especialidad = cmbEspecialidad.Text.Trim();
            ProfesorActual.TarifaHora = decimal.Parse(txtTarifa.Text.Trim());
            ProfesorActual.Activo = chkActivo.Checked;

            repo.AgregarProfesor(ProfesorActual);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}