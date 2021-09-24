using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;

namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioMaestro:IRepositorioMaestro
    {
        private readonly SeguiAcademico.App.Persistencia.AppContext _appContext;

        public RepositorioMaestro(SeguiAcademico.App.Persistencia.AppContext appContext)
        {
        _appContext = appContext;
        }

        Maestro IRepositorioMaestro.AñadirMaestro(Maestro maestro)
        {
            var NuevoMaestro= _appContext.Maestros.Add(maestro);
            _appContext.SaveChanges();
            return NuevoMaestro.Entity;
        }

        void IRepositorioMaestro.EliminarMaestro(int idMaestro)
        {
            var MaestroBuscado= _appContext.Maestros.FirstOrDefault(p => p.Id == idMaestro);
            if (MaestroBuscado==null)
            return;
            _appContext.Maestros.Remove(MaestroBuscado);
            _appContext.SaveChanges();
        }

        IEnumerable<Maestro> IRepositorioMaestro.ObtenerTodosMaestros()
        {
            return _appContext.Maestros;
        }

        Maestro IRepositorioMaestro.ActualizarMaestro(Maestro maestro)
        {
            var MaestroBuscado= _appContext.Maestros.FirstOrDefault(p => p.Id == maestro.Id);
            if(MaestroBuscado!=null)
            {
                MaestroBuscado.Nombre=maestro.Nombre;
                MaestroBuscado.Apellidos=maestro.Apellidos;
                MaestroBuscado.NumeroTelefono=maestro.NumeroTelefono;
                MaestroBuscado.Genero=maestro.Genero;
                MaestroBuscado.Materia=maestro.Materia;
                MaestroBuscado.CorreoInstitucional=maestro.CorreoInstitucional;
                MaestroBuscado.CursoACargo=maestro.CursoACargo;
                
                _appContext.SaveChanges();
            }
            return MaestroBuscado;
        }

        Maestro IRepositorioMaestro.BuscarMaestro(int idMaestro)
        {
            var MaestroBuscado= _appContext.Maestros.FirstOrDefault(p => p.Id == idMaestro);
            return MaestroBuscado;
        }
    }
    
}