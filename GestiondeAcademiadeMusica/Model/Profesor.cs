namespace GestiondeAcademiadeMusica
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }
        public decimal TarifaHora { get; set; }
        public bool Activo { get; set; }

        public Profesor()
        {
            Activo = true;
        }
    }
}
