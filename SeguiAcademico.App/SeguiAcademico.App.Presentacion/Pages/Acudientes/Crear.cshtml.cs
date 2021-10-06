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
public class CrearModel : PageModel
    {
        private readonly  IRepositorioAcudienteDesignado _repoAcudiente;
        public AcudienteDesignado acudiente{get;set;}
        public CrearModel (IRepositorioAcudienteDesignado _repoAcudiente)
        {
            this._repoAcudiente = _repoAcudiente;
        }
        public void OnGet()
        {
            acudiente = new AcudienteDesignado();

        }
        public IActionResult OnPost(AcudienteDesignado acudiente)
        {
            _repoAcudiente.AddAcudiente(acudiente);
            return RedirectToPage("Index");
        } 
    }
}
