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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioAcudienteDesignado _repoAcudiente;
        public AcudienteDesignado acudiente { get; set; }
        public ActualizarModel(IRepositorioAcudienteDesignado _repoAcudiente)
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
        public IActionResult OnPost(AcudienteDesignado acudiente)
        {
            _repoAcudiente.UpdateAcudiente(acudiente);
            return RedirectToPage("Index");
        }
    }
}
