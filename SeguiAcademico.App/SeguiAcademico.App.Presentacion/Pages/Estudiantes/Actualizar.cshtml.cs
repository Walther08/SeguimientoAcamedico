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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante { get; set; }
        public ActualizarModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }
        public IActionResult OnGet(int Id)
        {
            estudiante = _repoEstudiante.GetEstudiante(Id);

            if (estudiante == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
            
        }
        public IActionResult OnPost(Estudiante estudiante)
        {
            _repoEstudiante.UpdateEstudiante(estudiante);
            return RedirectToPage("Index");
        }
    }
}
