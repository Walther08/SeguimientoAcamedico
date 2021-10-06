using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Presentacion.Pages.Maestros
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        public Maestro maestro { get; set; }
        public ActualizarModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro = _repoMaestro;
        }
        public IActionResult OnGet(int Id)
        {
            maestro = _repoMaestro.GetMaestro(Id);

            if (maestro == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost(Maestro maestro)
        {
            _repoMaestro.UpdateMaestro(maestro);
            return RedirectToPage("Consultar");
        }
    }
}
