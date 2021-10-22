using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace SeguiAcademico.App.Presentacion.Pages.Tutores
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioTutor _repoTutor;
        public IEnumerable<Tutor> tutor {get;set;}
        public IndexModel(IRepositorioTutor _repoTutor)
        {
            this._repoTutor=_repoTutor;
        }

        public void OnGet()
        {
            tutor = _repoTutor.GetAllTutores();
        }
    }
}
