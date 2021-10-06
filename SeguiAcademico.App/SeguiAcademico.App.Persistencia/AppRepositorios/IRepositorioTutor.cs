using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioTutor
    {
    IEnumerable<Tutor> GetAllTutores();
    Tutor AddTutor (Tutor tutor);
    Tutor UpdateTutor (Tutor tutor);
    void DeleteTutor (int idTutor);
    Tutor GetTutor (int idTutor);
    
    }
    
}