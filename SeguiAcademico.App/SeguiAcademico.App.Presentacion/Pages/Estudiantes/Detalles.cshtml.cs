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
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> estudiante { get; set; }
        public DetallesModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }

        public void OnGet()
        {
            estudiante = _repoEstudiante.GetAllEstudiantes();
        }
    }
}
