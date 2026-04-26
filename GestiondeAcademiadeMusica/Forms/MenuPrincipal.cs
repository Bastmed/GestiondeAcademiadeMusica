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


namespace GestiondeAcademiadeMusica
{
    public partial class MenuPrincipal : Form
    {
        private AcademiaRepositorio repo;
        private Uc_Alumnos ucAlumnos;

        public MenuPrincipal()
        {
            InitializeComponent();
            repo = new AcademiaRepositorio();
            ucAlumnos = new Uc_Alumnos(repo);

            ucAlumnos.Dock = DockStyle.Fill;

        }
        private void MostrarControl(UserControl control)
        {
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(control);
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAlumno = new AgregarAlumno(repo);
            formAlumno.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MostrarControl(ucAlumnos);
        }
    }
}
