using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeAcademiadeMusica
{
    public partial class Form2 : Form
    {
        public AcademiaRepositorio repo = new AcademiaRepositorio();

        public Form2()
        {
            InitializeComponent();
        }
        //AUN HAY Q CREAR LOS FORMULARIOS DE INSTRUMENTOS, ALUMNOS Y PROFESORES, PERO YA SE LES PASA EL REPOSITORIO PARA Q PUEDAN MANEJAR LOS DATOS AAAAAAAAAAAAAAAAA 
        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            FormInstrumentos formInstrumentos = new FormInstrumentos(repo);
            formInstrumentos.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new FormAlumnos(repo);
            formAlumnos.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores(repo);
            formProfesores.ShowDialog();
        }
    }
}
