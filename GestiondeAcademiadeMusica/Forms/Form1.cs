namespace GestiondeAcademiadeMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = "webo";
            String contraseña = "del1al8";

            if (txtNombreUsuario.Text == usuario && txtContraseñaUsuario.Text == contraseña)
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }
    }
}
