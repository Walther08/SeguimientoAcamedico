using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Presentacion.Pages.Tutores
{
    public class CrearModel : PageModel
    {
        private readonly  IRepositorioTutor _repoTutor;
        public Tutor tutor{get;set;}
        public CrearModel (IRepositorioTutor _repoTutor)
        {
            this._repoTutor = _repoTutor;
        }
        public void OnGet()
        {
            tutor = new Tutor();

        }
        public IActionResult OnPost(Tutor tutor)
        {
            _repoTutor.AddTutor(tutor);
            return RedirectToPage("Index");
        } 
    }
}
