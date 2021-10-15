using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;


namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext = new AppContext();
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }
        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);

            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.Nombre = estudiante.Nombre;
                estudianteEncontrado.Apellidos = estudiante.Apellidos;
                estudianteEncontrado.NumeroTelefono = estudiante.NumeroTelefono;
                estudianteEncontrado.Genero = estudiante.Genero;
                estudianteEncontrado.Curso = estudiante.Curso;
                estudianteEncontrado.Direccion = estudiante.Direccion;
                estudianteEncontrado.Ciudad = estudiante.Ciudad;
                estudianteEncontrado.FechaNacimiento = estudiante.FechaNacimiento;
                estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                estudianteEncontrado.Historiales = estudiante.Historiales;
                estudianteEncontrado.AcudienteDesignado = estudiante.AcudienteDesignado;
                estudianteEncontrado.Maestro = estudiante.Maestro;
                estudianteEncontrado.Tutor = estudiante.Tutor;

                _appContext.SaveChanges();

            }

            return estudianteEncontrado;
        }
        void IRepositorioEstudiante.DeleteEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }
        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            return estudianteEncontrado;
        }
        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

        void IRepositorioEstudiante.AddHistorial(int IdEstudiante, Historial historial)
        {
            var estudiante = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudiante != null)
            {
                if (estudiante.Historiales != null)
                {
                    estudiante.Historiales.Add(historial);
                }
                else
                {
                    estudiante.Historiales = new List<Historial>();
                    estudiante.Historiales.Add(historial);  
                }
                var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
                if (estudianteEncontrado != null)
                {
                    estudianteEncontrado.Nombre = estudiante.Nombre;
                    estudianteEncontrado.Apellidos = estudiante.Apellidos;
                    estudianteEncontrado.NumeroTelefono = estudiante.NumeroTelefono;
                    estudianteEncontrado.Genero = estudiante.Genero;
                    estudianteEncontrado.Curso = estudiante.Curso;
                    estudianteEncontrado.Direccion = estudiante.Direccion;
                    estudianteEncontrado.Ciudad = estudiante.Ciudad;
                    estudianteEncontrado.FechaNacimiento = estudiante.FechaNacimiento;
                    estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                    estudianteEncontrado.Historiales = estudiante.Historiales;
                    estudianteEncontrado.AcudienteDesignado = estudiante.AcudienteDesignado;
                    estudianteEncontrado.Maestro = estudiante.Maestro;
                    estudianteEncontrado.Tutor = estudiante.Tutor;

                    _appContext.SaveChanges();
                }

            }
        }

        void IRepositorioEstudiante.AsignMaestro(int IdEstudiante, Maestro maestro)
        {
            var estudiante = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudiante != null)
            {
                if (estudiante.Maestro != null)
                {
                    estudiante.Maestro.Add(maestro);
                }
                else
                {
                    estudiante.Maestro = new List<Maestro>();
                    estudiante.Maestro.Add(maestro);
                }
                var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
                if (estudianteEncontrado != null)
                {
                    estudianteEncontrado.Nombre = estudiante.Nombre;
                    estudianteEncontrado.Apellidos = estudiante.Apellidos;
                    estudianteEncontrado.NumeroTelefono = estudiante.NumeroTelefono;
                    estudianteEncontrado.Genero = estudiante.Genero;
                    estudianteEncontrado.Curso = estudiante.Curso;
                    estudianteEncontrado.Direccion = estudiante.Direccion;
                    estudianteEncontrado.Ciudad = estudiante.Ciudad;
                    estudianteEncontrado.FechaNacimiento = estudiante.FechaNacimiento;
                    estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                    estudianteEncontrado.Historiales = estudiante.Historiales;
                    estudianteEncontrado.AcudienteDesignado = estudiante.AcudienteDesignado;
                    estudianteEncontrado.Maestro = estudiante.Maestro;
                    estudianteEncontrado.Tutor = estudiante.Tutor;

                    _appContext.SaveChanges();
                }
            }
        }

        void IRepositorioEstudiante.AsignTutor(int IdEstudiante, Tutor tutor)
        {
            var estudiante = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudiante != null)
            {
                if (estudiante.Tutor != null)
                {
                    estudiante.Tutor.Add(tutor);
                }
                else
                {
                    estudiante.Tutor = new List<Tutor>();
                    estudiante.Tutor.Add(tutor);
                }
                var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
                if (estudianteEncontrado != null)
                {
                    estudianteEncontrado.Nombre = estudiante.Nombre;
                    estudianteEncontrado.Apellidos = estudiante.Apellidos;
                    estudianteEncontrado.NumeroTelefono = estudiante.NumeroTelefono;
                    estudianteEncontrado.Genero = estudiante.Genero;
                    estudianteEncontrado.Curso = estudiante.Curso;
                    estudianteEncontrado.Direccion = estudiante.Direccion;
                    estudianteEncontrado.Ciudad = estudiante.Ciudad;
                    estudianteEncontrado.FechaNacimiento = estudiante.FechaNacimiento;
                    estudianteEncontrado.MateriasInscritas = estudiante.MateriasInscritas;
                    estudianteEncontrado.Historiales = estudiante.Historiales;
                    estudianteEncontrado.AcudienteDesignado = estudiante.AcudienteDesignado;
                    estudianteEncontrado.Maestro = estudiante.Maestro;
                    estudianteEncontrado.Tutor = estudiante.Tutor;

                    _appContext.SaveChanges();
                }
            }
        }

        void IRepositorioEstudiante.AsignAcudienteDesignado(int IdEstudiante, int IdAcudienteDesignado)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if (estudianteEncontrado != null)
            {
                var acudienteEncontrado = _appContext.AcudientesDesignados.FirstOrDefault(a => a.Id == IdAcudienteDesignado);
                if (acudienteEncontrado != null)
                {
                    estudianteEncontrado.AcudienteDesignado = acudienteEncontrado;
                    _appContext.SaveChanges();
                }
            }
        }
    }
}
