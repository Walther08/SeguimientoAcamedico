using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioMaestro
    {
        IEnumerable<Maestro> GetAllMaestros();
        Maestro AddMaestro(Maestro maestro);
        Maestro UpdateMaestro (Maestro maestro);
        void DeleteMaestro (int idMaestro);
        Maestro GetMaestro (int idMaestro);
    }
}