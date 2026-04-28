using System.ComponentModel;

namespace GestiondeAcademiadeMusica
{
    public class AcademiaRepositorio
    {
        public BindingList<Instrumento> Instrumentos { get; } = new BindingList<Instrumento>();
        public BindingList<Alumno> Alumnos { get; } = new BindingList<Alumno>();
        public BindingList<Profesor> Profesores { get; } = new BindingList<Profesor>();

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
            var existing = Instrumentos.FirstOrDefault(x => x.IdInstrumento == i.IdInstrumento);
            if (existing != null)
            {
                existing.Nombre = i.Nombre;
                existing.Categoria = i.Categoria;
                existing.Marca = i.Marca;
                existing.Estado = i.Estado;
            }
        }

        public void EliminarInstrumento(int id)
        {
            var item = Instrumentos.FirstOrDefault(x => x.IdInstrumento == id);
            if (item != null) Instrumentos.Remove(item);
        }

        // ALUMNOS

        public void AgregarAlumno(Alumno a)
        {
            a.IdAlumno = _nextIdAlumno++;
            Alumnos.Add(a);
        }

        public void ActualizarAlumno(Alumno a)
        {
            var existing = Alumnos.FirstOrDefault(x => x.IdAlumno == a.IdAlumno);
            if (existing != null)
            {
                existing.Nombre = a.Nombre;
                existing.Apellido = a.Apellido;
                existing.FechaNacimiento = a.FechaNacimiento;
                existing.Telefono = a.Telefono;
                existing.Email = a.Email;
                existing.Activo = a.Activo;
                existing.IdInstrumento = a.IdInstrumento;
                existing.NombreInstrumento = a.NombreInstrumento;
            }
        }

        public void EliminarAlumno(int id)
        {
            var item = Alumnos.FirstOrDefault(x => x.IdAlumno == id);
            if (item != null) Alumnos.Remove(item);
        }

        // PROFESORES

        public void AgregarProfesor(Profesor p)
        {
            p.IdProfesor = _nextIdProfesor++;
            Profesores.Add(p);
        }

        public void ActualizarProfesor(Profesor p)
        {
            var existing = Profesores.FirstOrDefault(x => x.IdProfesor == p.IdProfesor);
            if (existing != null)
            {
                existing.Nombre = p.Nombre;
                existing.Apellido = p.Apellido;
                existing.Telefono = p.Telefono;
                existing.Email = p.Email;
                existing.Especialidad = p.Especialidad;
                existing.TarifaHora = p.TarifaHora;
                existing.Activo = p.Activo;
            }
        }

        public void EliminarProfesor(int id)
        {
            var item = Profesores.FirstOrDefault(x => x.IdProfesor == id);
            if (item != null) Profesores.Remove(item);
        }

        private void CargarDatosEjemplo()
        {
            AgregarInstrumento(new Instrumento { Nombre = "Guitarra", Categoria = "Cuerda Pulsada", Marca = "Yamaha" });
            AgregarInstrumento(new Instrumento { Nombre = "Piano", Categoria = "Cuerda Percutida", Marca = "Casio" });

            AgregarProfesor(new Profesor { Nombre = "Carlos", Apellido = "Mendoza", Telefono = "912345678", Email = "carlos@academia.cl", Especialidad = "Guitarra Clásica", TarifaHora = 15000 });

            AgregarAlumno(new Alumno { Nombre = "Pedro", Apellido = "González", Telefono = "911111111", FechaNacimiento = new DateTime(2005, 3, 12), Email = "pedro@mail.com", Activo = true, IdInstrumento = 1, NombreInstrumento = "Guitarra" });
        }
    }
}