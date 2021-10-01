using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;


namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioRecomendacion : IRepositorioRecomendacion
    {
        private readonly AppContext _appContext = new AppContext();
        
        Recomendacion IRepositorioRecomendacion.AddRecomendacion(Recomendacion recomendacion)
        {
            var RecomendacionAdicionada= _appContext.RecomendacionAcademica.Add(recomendacion);
            _appContext.SaveChanges();
            return RecomendacionAdicionada.Entity;
        }
        Recomendacion IRepositorioRecomendacion.UpdateRecomendacion(Recomendacion recomendacion)
        {
            var recomendacionEncontrada= _appContext.RecomendacionAcademica.FirstOrDefault(r => r.Id == recomendacion.Id);
            if(recomendacionEncontrada!=null)
            {
                recomendacionEncontrada.FechaPublicacion= recomendacion.FechaPublicacion;
                recomendacionEncontrada.FechaEntrega= recomendacion.FechaEntrega;
                recomendacionEncontrada.Materia= recomendacion.Materia;
                recomendacionEncontrada.Tematica= recomendacion.Tematica;
                recomendacionEncontrada.MaestroEncargado= recomendacion.MaestroEncargado;
                recomendacionEncontrada.TipoActividad= recomendacion.TipoActividad;
                recomendacionEncontrada.EstadoAvance= recomendacion.EstadoAvance;
                

                _appContext.SaveChanges();
                
            }

            return recomendacionEncontrada;
        }
        void IRepositorioRecomendacion.DeleteRecomendacion(int IdRecomendacion)
        {
            var recomendacionEncontrada= _appContext.RecomendacionAcademica.FirstOrDefault(r => r.Id == IdRecomendacion);
            if(recomendacionEncontrada==null)
            return;
            _appContext.RecomendacionAcademica.Remove(recomendacionEncontrada);
            _appContext.SaveChanges();
        }
        Recomendacion IRepositorioRecomendacion.GetRecomendacion(int IdRecomendacion)
        {
            var recomendacionEncontrada= _appContext.RecomendacionAcademica.FirstOrDefault(r => r.Id == IdRecomendacion);
            return recomendacionEncontrada;
        }
        IEnumerable<Recomendacion> IRepositorioRecomendacion.GetAllRecomendaciones()
        {
            return _appContext.RecomendacionAcademica;
        }

        
                  
    }
}
