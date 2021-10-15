using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Dominio;
using SeguiAcademico.App.Persistencia;

namespace SeguiAcademico.App.Presentacion.Pages.Estudiantes
{
    public class HistorialModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante { get; set; }
        public Historial historiales { get; set; }
        public Recomendacion recomendacion { get; set; }
        public HistorialModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }
        public IActionResult OnGet(int Id)
        {
            estudiante=_repoEstudiante.GetEstudiante(Id);
            if(estudiante!=null)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult OnPost(int Id, Historial historiales)
        {
            _repoEstudiante.AddHistorial(Id, historiales);
            return RedirectToPage("Index");
        }
    }
}
