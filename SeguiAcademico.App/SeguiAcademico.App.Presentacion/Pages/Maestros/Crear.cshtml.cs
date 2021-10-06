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
    public class CrearModel : PageModel
    {
        private readonly IRepositorioMaestro _repoMaestro;
        public Maestro maestro { get; set; }
        public CrearModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro = _repoMaestro;
        }
        public void OnGet()
        {
            maestro = new Maestro();
        }
        public IActionResult OnPost(Maestro maestro)
        {
            _repoMaestro.AddMaestro(maestro);
            return RedirectToPage("Consultar");
        } 

    }
}
