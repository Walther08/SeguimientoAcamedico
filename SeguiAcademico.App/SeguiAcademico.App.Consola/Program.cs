using System;
using SeguiAcademico.App.Dominio;
using SeguiAcademico.App.Persistencia;

namespace SeguiAcademico.App.Consola
{
    class Program
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

        private static IRepositorioMaestro _repoMaestro = new RepositorioMaestro(new Persistencia.AppContext());

        private static IRepositorioAcudienteDesignado _repoAcudiente = new RepositorioAcudienteDesignado(new Persistencia.AppContext());

        private static IRepositorioTutor _repoTutor = new RepositorioTutor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Aplicación de seguimiento académico =), PRUEBA 1. ");
            // AddEstudiante();
            //BuscarEstudiante(1);
            //AñadirMaestro();
            //BuscarMastro(2);
            //AñadirAcudiente();
            //BuscarAcudiente(3);
            //AñadirTutor();
            BuscarTutor(4);

        }

        private static void AddEstudiante()
        {
            var estudiante = new Estudiante
            {
                Nombre = "Walther",
                Apellidos = "González",
                NumeroTelefono = "3144448598",
                Genero = Genero.Masculino,
                Curso = "Segundo",
                Direccion = "Calle asdasda",
                Latitud = 3.00F,
                Longitud = 38.01F,
                Ciudad = "Ibagué",
                FechaNacimiento = new DateTime(1998, 08, 25),
                MateriasInscritas = "Inglés y Biología"
            };

            _repoEstudiante.AddEstudiante(estudiante);
        }

        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine(estudiante.Nombre + " " + estudiante.Apellidos);
        }

        private static void AñadirMaestro()
        {
            var maestro = new Maestro
            {
                Nombre = "Maestro",
                Apellidos = "Uno",
                NumeroTelefono = "311111111",
                Genero = Genero.Masculino,
                Materia = "Biología",
                CorreoInstitucional = "maestro@mail.edu.co",
                CursoACargo = "Segundo"
            };
            
            _repoMaestro.AñadirMaestro(maestro); 
        }

        private static void BuscarMastro(int idMaestro)
        {
            var maestro = _repoMaestro.BuscarMaestro(idMaestro);
            Console.WriteLine("El maestro "+maestro.Nombre + " " + maestro.Apellidos+" fue hallado");
        }

        private static void AñadirAcudiente()
        {
            var acudiente = new AcudienteDesignado
            {
                Nombre = "Acudiente",
                Apellidos = "Uno",
                NumeroTelefono = "322222222",
                Genero = Genero.Masculino,
                Parentesco = "Padre",
                CorreoElectronico = "acudiente@mail.com"
            };
            _repoAcudiente.AddAcudiente(acudiente);
        }

        private static void BuscarAcudiente(int IdAcudiente)
        {
            var acudiente = _repoAcudiente.GetAcudiente(IdAcudiente);
            Console.WriteLine("El acudiente "+acudiente.Nombre + " " + acudiente.Apellidos+" fue hallado");
        }

        private static void AñadirTutor()
        {
            var tutor = new Tutor
            {
                Nombre = "Tutor",
                Apellidos = "Uno",
                NumeroTelefono = "300000000",
                Genero = Genero.Masculino,
                MateriaTutoria = "Biología",
                HorasLaborales = 4,
                CorreoInstitucional = "tutor@mail.edu.co"
            };

            _repoTutor.AddTutor(tutor);
        }

        private static void BuscarTutor(int IdTutor)
        {
            var tutor = _repoTutor.GetTutor(IdTutor);
            Console.WriteLine("El tutor "+tutor.Nombre + " " + tutor.Apellidos+" fue hallado");
        }
    }

}
