using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Presentacion.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;  
        public IEnumerable<Estudiante> estudiantes{get;set;} 
        public IndexModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante= _repoEstudiante;
        }
        
        public void OnGet()
        {
            estudiantes= _repoEstudiante.GetAllEstudiantes();
        }
        
    }
}
