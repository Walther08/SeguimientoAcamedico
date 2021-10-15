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
public class AssignTutorModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante { get; set; }
        public Tutor tutor { get; set; }
        public AssignTutorModel(IRepositorioEstudiante _repoEstudiante)
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

        public IActionResult OnPost(int Id, Tutor tutor)
        {
            _repoEstudiante.AsignTutor(Id, tutor);
            return RedirectToPage("Index");
        }
    }
}
