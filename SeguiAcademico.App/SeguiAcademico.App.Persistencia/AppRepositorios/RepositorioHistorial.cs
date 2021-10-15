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
            var historialAdicionado= _appContext.Historiales.Add(historial);
            _appContext.SaveChanges();
            return historialAdicionado.Entity;
        }
        Historial IRepositorioHistorial.UpdateHistorial(Historial historial)
        {
            var historialEncontrado= _appContext.Historiales.FirstOrDefault(h => h.HistorialId == historial.HistorialId);
            if(historialEncontrado!=null)
            {
                historialEncontrado.Observaciones= historial.Observaciones;
                historialEncontrado.RecomendacionAcademica= historial.RecomendacionAcademica;
                
                _appContext.SaveChanges();
                
            }

            return historialEncontrado;
        }

        void IRepositorioHistorial.DeleteHistorial(int IdHistorial)
        {
            var historialEncontrado= _appContext.Historiales.FirstOrDefault(h => h.HistorialId == IdHistorial);
            if(historialEncontrado==null)
            return;
            _appContext.Historiales.Remove(historialEncontrado);
            _appContext.SaveChanges();
        }

        Historial IRepositorioHistorial.GetHistorial(int IdHistorial)
        {
            var historialEncontrado= _appContext.Historiales.FirstOrDefault(h => h.HistorialId == IdHistorial);
            return historialEncontrado;
        }

        IEnumerable<Historial> IRepositorioHistorial.GetAllHistoriales()
        {
            return _appContext.Historiales;
        }

    }
}