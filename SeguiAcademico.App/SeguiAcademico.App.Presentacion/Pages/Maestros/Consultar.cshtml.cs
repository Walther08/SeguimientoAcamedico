using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace SeguiAcademico.App.Presentacion.Pages.Maestros
{
    [Authorize]
    public class ConsultarModel : PageModel
    {

        private readonly IRepositorioMaestro _repoMaestro;
        public IEnumerable<Maestro> maestro { get; set; }
        public ConsultarModel(IRepositorioMaestro _repoMaestro)
        {
            this._repoMaestro = _repoMaestro;
        }
        public void OnGet()
        {
            maestro = _repoMaestro.GetAllMaestros();
        }

    }

}
