using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;


namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioHistorial : IRepositorioHistorial
    {
        private readonly AppContext _appContext = new AppContext();

        Historial IRepositorioHistorial.AddHistorial(Historial historial)
        {
            var historialAdicionado= _appContext.Historial.Add(historial);
            _appContext.SaveChanges();
            return historialAdicionado.Entity;
        }
        Historial IRepositorioHistorial.UpdateHistorial(Historial historial)
        {
            var historialEncontrado= _appContext.Historial.FirstOrDefault(h => h.HistorialId == historial.HistorialId);
            if(historialEncontrado!=null)
            {
                historialEncontrado.Observaciones= historial.Observaciones;
                historialEncontrado.RecomendacionAcademica= historial.RecomendacionAcademica;
                historialEncontrado.InformeSeguimiento= historial.InformeSeguimiento;
                
                _appContext.SaveChanges();
                
            }

            return historialEncontrado;
        }

        void IRepositorioHistorial.DeleteHistorial(int IdHistorial)
        {
            var historialEncontrado= _appContext.Historial.FirstOrDefault(h => h.HistorialId == IdHistorial);
            if(historialEncontrado==null)
            return;
            _appContext.Historial.Remove(historialEncontrado);
            _appContext.SaveChanges();
        }

        Historial IRepositorioHistorial.GetHistorial(int IdHistorial)
        {
            var historialEncontrado= _appContext.Historial.FirstOrDefault(h => h.HistorialId == IdHistorial);
            return historialEncontrado;
        }

        Recomendacion IRepositorioHistorial.AsignRecomendacion (int IdHistorial, int IdRecomendacion)
        {
            var historialEncontrado = _appContext.Historial.FirstOrDefault(h => h.HistorialId == IdHistorial);
            if(historialEncontrado!=null)
            {
                var recomendacionEncontrada = _appContext.RecomendacionAcademica.FirstOrDefault(r => r.RecomendacionId == IdRecomendacion);
                if(recomendacionEncontrada!=null)
                {
                    historialEncontrado.RecomendacionAcademica = recomendacionEncontrada;
                    _appContext.SaveChanges();
                }
                return recomendacionEncontrada;
            }
            return null;
        }

        Informe IRepositorioHistorial.AsignInforme (int IdHistorial, int IdInforme)
        {
            var historialEncontrado = _appContext.Historial.FirstOrDefault(h => h.HistorialId == IdHistorial);
            if(historialEncontrado!=null)
            {
                var informeEncontrado = _appContext.Informe.FirstOrDefault(i => i.InformeId == IdInforme);
                if(informeEncontrado!=null)
                {
                    historialEncontrado.InformeSeguimiento = informeEncontrado;
                    _appContext.SaveChanges();
                }
                return informeEncontrado;
            }
            return null;
        }

    }
}