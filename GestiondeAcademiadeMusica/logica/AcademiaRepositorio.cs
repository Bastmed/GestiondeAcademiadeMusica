namespace GestiondeAcademiadeMusica
{
    public class AcademiaRepositorio
    {
        public List<Instrumento> Instrumentos = new List<Instrumento>();
        public List<Alumno> Alumnos = new List<Alumno>();
        public List<Profesor> Profesores = new List<Profesor>();

        private int _nextIdInstrumento = 1;
        private int _nextIdAlumno = 1;
        private int _nextIdProfesor = 1;

        public AcademiaRepositorio()
        {
            CargarDatosEjemplo();
        }

        // INSTRUMENTOS

        public void AgregarInstrumento(Instrumento i)
        {
            i.IdInstrumento = _nextIdInstrumento++;
            Instrumentos.Add(i);
        }

        public void ActualizarInstrumento(Instrumento i)
        {
            int idx = Instrumentos.FindIndex(x => x.IdInstrumento == i.IdInstrumento);
            if (idx >= 0)
                Instrumentos[idx] = i;
        }

        public void EliminarInstrumento(int id)
        {
            Instrumentos.RemoveAll(x => x.IdInstrumento == id);
        }

        // ALUMNOS

        public void AgregarAlumno(Alumno a)
        {
            a.IdAlumno = _nextIdAlumno++;
            Alumnos.Add(a);
        }

        public void ActualizarAlumno(Alumno a)
        {
            int idx = Alumnos.FindIndex(x => x.IdAlumno == a.IdAlumno);
            if (idx >= 0)
                Alumnos[idx] = a;
        }

        public void EliminarAlumno(int id)
        {
            Alumnos.RemoveAll(x => x.IdAlumno == id);
        }

        // PROFESORES

        public void AgregarProfesor(Profesor p)
        {
            p.IdProfesor = _nextIdProfesor++;
            Profesores.Add(p);
        }

        public void ActualizarProfesor(Profesor p)
        {
            int idx = Profesores.FindIndex(x => x.IdProfesor == p.IdProfesor);
            if (idx >= 0)
                Profesores[idx] = p;
        }

        public void EliminarProfesor(int id)
        {
            Profesores.RemoveAll(x => x.IdProfesor == id);
        }

        private void CargarDatosEjemplo()
        {
            AgregarInstrumento(new Instrumento { Nombre = "Guitarra", Categoria = "Cuerda", Marca = "Yamaha", PrecioMensual = 15000 });
            AgregarInstrumento(new Instrumento { Nombre = "Piano", Categoria = "Teclas", Marca = "Casio", PrecioMensual = 20000 });

            AgregarProfesor(new Profesor { Nombre = "Carlos", Apellido = "Mendoza", Telefono = "912345678", Email = "carlos@academia.cl", Especialidad = "Guitarra", TarifaHora = 15000 });

            AgregarAlumno(new Alumno { Nombre = "Pedro", Apellido = "González", Telefono = "911111111", Email = "pedro@mail.com", FechaNacimiento = new DateTime(2005, 3, 12), IdInstrumento = 1 });
        }
    }
}