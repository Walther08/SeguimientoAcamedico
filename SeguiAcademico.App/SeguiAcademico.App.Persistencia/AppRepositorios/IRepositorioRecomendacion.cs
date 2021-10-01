using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioRecomendacion
    {
    IEnumerable<Recomendacion> GetAllRecomendaciones();
    Recomendacion AddRecomendacion (Recomendacion recomendacion);
    Recomendacion UpdateRecomendacion (Recomendacion recomendacion);
    void DeleteRecomendacion (int IdRecomendacion);
    Recomendacion GetRecomendacion (int IdRecomendacion);
    
    
    }
    
}