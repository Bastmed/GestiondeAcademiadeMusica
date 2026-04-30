namespace GestiondeAcademiadeMusica
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = "webo";
            String contraseña = "123";

            if (txtNombreUsuario.Text == usuario && txtContraseñaUsuario.Text == contraseña)
            {
                MessageBox.Show("¡Inicio de sesión exitoso!");
                MenuPrincipal form2 = new MenuPrincipal();
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
