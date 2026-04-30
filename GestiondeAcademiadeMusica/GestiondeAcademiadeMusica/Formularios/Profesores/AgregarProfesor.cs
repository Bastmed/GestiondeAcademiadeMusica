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

        private bool Validar()
        {
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.Add("Nombre obligatorio");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
                errores.Add("Apellido obligatorio");

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
                errores.Add("Email inválido");

            if (string.IsNullOrWhiteSpace(cmbEspecialidad.Text))
                errores.Add("Especialidad obligatoria");

            if (!decimal.TryParse(txtTarifa.Text.Trim(), out decimal tarifa) || tarifa <= 0)
                errores.Add("Tarifa por hora inválida (debe ser un número mayor a 0)");

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