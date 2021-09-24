using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioTutor
    {
    IEnumerable<Tutor> GetAllTutor();
    Tutor AddTutor (Tutor tutor);
    Tutor UpdateTutor (Tutor tutor);
    void DeleteTutor (int IdTutor);
    Tutor GetTutor (int IdTutor);
    
    }
    
}