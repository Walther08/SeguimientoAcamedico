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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public Tutor tutor { get; set; }
        public ActualizarModel(IRepositorioTutor _repoTutor)
        {
            this._repoTutor = _repoTutor;
        }
        public IActionResult OnGet(int Id)
        {
            tutor = _repoTutor.GetTutor(Id);

            if (tutor == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost(Tutor tutor)
        {
            _repoTutor.UpdateTutor(tutor);
            return RedirectToPage("Index");
        }
    }
}
