using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioHistorial
    {
    Historial AddHistorial (Historial historial);
    Historial GetHistorial (int IdHistorial);
    void DeleteHistorial (int IdHistorial);
    Historial UpdateHistorial (Historial historial);
    IEnumerable<Historial> GetAllHistoriales();
    
    }
}