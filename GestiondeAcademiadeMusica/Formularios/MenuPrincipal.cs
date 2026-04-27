using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeAcademiadeMusica.Forms;
using GestiondeAcademiadeMusica.Forms.UserControls;

namespace GestiondeAcademiadeMusica
{
    public partial class MenuPrincipal : Form
    {
        private AcademiaRepositorio repo;
        private Uc_Alumnos ucAlumnos;
        private Uc_Instrumentos ucInstrumentos;
        private Uc_Profesores ucProfesores;

        public MenuPrincipal()
        {
            InitializeComponent();

            repo = new AcademiaRepositorio();

            ucAlumnos = new Uc_Alumnos(repo);
            ucInstrumentos = new Uc_Instrumentos(repo);

            // --- EL CAMBIO ESTÁ AQUÍ ---
            // Ahora nace igual que Alumnos e Instrumentos
            ucProfesores = new Uc_Profesores(repo);
            // ---------------------------

            ucAlumnos.Dock = DockStyle.Fill;
            ucInstrumentos.Dock = DockStyle.Fill;
            ucProfesores.Dock = DockStyle.Fill;
        }

        private void MostrarControl(UserControl control)
        {
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(control);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            MostrarControl(ucProfesores);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MostrarControl(ucAlumnos);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            MostrarControl(ucInstrumentos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAlumno = new AgregarAlumno(repo);
            formAlumno.Show();
        }
    }
}