using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;

namespace SeguiAcademico.App.Persistencia
{
    public interface IRepositorioAcudienteDesignado
    {
    IEnumerable<AcudienteDesignado> GetAllAcudiente();
    AcudienteDesignado AddAcudiente (AcudienteDesignado acudiente);
    AcudienteDesignado UpdateAcudiente (AcudienteDesignado acudiente);
    void DeleteAcudiente (int IdAcudiente);
    AcudienteDesignado GetAcudiente (int IdAcudiente);
    
    }
    
}