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
            var estudianteAdicionado= _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }
        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
            
            if(estudianteEncontrado!=null)
            {
                estudianteEncontrado.Nombre= estudiante.Nombre;
                estudianteEncontrado.Apellidos= estudiante.Apellidos;
                estudianteEncontrado.NumeroTelefono= estudiante.NumeroTelefono;
                estudianteEncontrado.Genero= estudiante.Genero;
                estudianteEncontrado.Curso= estudiante.Curso;
                estudianteEncontrado.Direccion= estudiante.Direccion;
                estudianteEncontrado.Latitud= estudiante.Latitud;
                estudianteEncontrado.Longitud= estudiante.Longitud;
                estudianteEncontrado.Ciudad= estudiante.Ciudad;
                estudianteEncontrado.FechaNacimiento= estudiante.FechaNacimiento;
                estudianteEncontrado.MateriasInscritas= estudiante.MateriasInscritas;
                estudianteEncontrado.AcudienteDesignado= estudiante.AcudienteDesignado;
                estudianteEncontrado.Maestro= estudiante.Maestro;
                estudianteEncontrado.Tutor= estudiante.Tutor;
                estudianteEncontrado.Historial= estudiante.Historial;

                _appContext.SaveChanges();
                
            }

            return estudianteEncontrado;
        }
        void IRepositorioEstudiante.DeleteEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            if(estudianteEncontrado==null)
            return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }
        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
            return estudianteEncontrado;
        }
        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

        // AcudienteDesignado IRepositorioEstudiante.AsignAcudienteDesignado (int IdEstudiante, int IdAcudienteDesignado)
        // {
        //     var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
        //     if(estudianteEncontrado!=null)
        //     {
        //         var acudienteEncontrado = _appContext.AcudientesDesignados.FirstOrDefault(a => a.Id == IdAcudienteDesignado);
        //         if(acudienteEncontrado!=null)
        //         {
        //             estudianteEncontrado.AcudienteDesignado = acudienteEncontrado;
        //             _appContext.SaveChanges();
        //         }
        //         return acudienteEncontrado;
        //     }
        //     return null;
        // }
        // Maestro IRepositorioEstudiante.AsignMaestro(int IdMaestro, int IdEstudiante) 
        // {
        //     var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.Id == IdEstudiante);
        //     if(estudianteEncontrado!=null)
        //     {
        //         var maestroEncontrado = _appContext.Maestros.FirstOrDefault(m => m.Id == IdMaestro);
        //         if(maestroEncontrado!=null)
        //         {
        //             estudianteEncontrado.Maestro = maestroEncontrado;
        //             _appContext.SaveChanges();
        //         }
        //         return maestroEncontrado;
        //     }
        //     return null;
        // }
                  
    }
}
