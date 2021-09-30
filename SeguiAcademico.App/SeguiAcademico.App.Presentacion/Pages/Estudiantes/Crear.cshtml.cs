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
    public class CrearModel : PageModel
    {
        private readonly  IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante{get;set;}
        public CrearModel (IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante = _repoEstudiante;
        }
        public void OnGet()
        {
            estudiante = new Estudiante();

        }
        public IActionResult onPost(Estudiante estudiante)
        {
            _repoEstudiante.AddEstudiante(estudiante);
            return RedirectToPage("Index");
        } 
    }
}
