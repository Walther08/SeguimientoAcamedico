using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioMaestro
    {
        IEnumerable<Maestro> ObtenerTodosMaestros();
        Maestro AñadirMaestro(Maestro maestro);
        Maestro ActualizarMaestro (Maestro maestro);
        void EliminarMaestro (int idMaestro);
        Maestro BuscarMaestro (int idMaestro);
    }
}