using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioInforme
    {
    IEnumerable<Informe> GetAllInformes();
    Informe AddInforme (Informe informe);
    Informe UpdateInforme (Informe informe);
    void DeleteInforme (int IdInforme);
    Informe GetInforme (int IdInforme);
    
    }
    
}
