using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiAcademico.App.Persistencia;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Presentacion.Pages.Acudientes
{
    public class EliminarModel : PageModel
    {
        public readonly IRepositorioAcudienteDesignado _repoAcudiente;
        public AcudienteDesignado acudiente { get; set; }
        public EliminarModel(IRepositorioAcudienteDesignado _repoAcudiente)
        {
            this._repoAcudiente = _repoAcudiente;
        }
        public IActionResult OnGet(int Id)
        {
            acudiente = _repoAcudiente.GetAcudiente(Id);
            if (acudiente == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int Id)
        {
            _repoAcudiente.DeleteAcudiente(Id);
            return RedirectToPage("Index");
        }
    }
}
