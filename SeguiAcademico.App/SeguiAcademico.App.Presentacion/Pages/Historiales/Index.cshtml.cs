using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace SeguiAcademico.App.Presentacion.Pages.Historiales
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioHistorial _repoHistorial;
        public IEnumerable<Historial>  historial { get; set; }
        public IEnumerable<Recomendacion> recomendacion { get; set; }
        // public Estudiante estudiante { get; set; }
        public IndexModel(IRepositorioHistorial _repoHistorial)
        {
            this._repoHistorial = _repoHistorial;
        }
        public void OnGet()
        {
            historial = _repoHistorial.GetAllHistoriales();
        }

    }
}
