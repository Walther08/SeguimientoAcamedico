using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
    IEnumerable<Estudiante> GetAllEstudiantes();
    Estudiante AddEstudiante (Estudiante estudiante);
    Estudiante UpdateEstudiante (Estudiante estudiante);
    void DeleteEstudiante (int IdEstudiante);
    Estudiante GetEstudiante (int IdEstudiante);
    void AddHistorial (int IdEstudiante, Historial historiales);
    void AsignAcudienteDesignado (int IdEstudiante, int IdAcudienteDesignado);
    void AsignMaestro (int IdEstudiante, Maestro maestro);
    void AsignTutor (int IdEstudiante, Tutor tutor);
    
    }
    
}