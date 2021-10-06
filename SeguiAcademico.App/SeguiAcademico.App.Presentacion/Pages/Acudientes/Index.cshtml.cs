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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioAcudienteDesignado _repoAcudiente;  
        public IEnumerable<AcudienteDesignado> acudienteDesignado{get;set;} 
        public IndexModel(IRepositorioAcudienteDesignado _repoAcudiente)
        {
            this._repoAcudiente= _repoAcudiente;
        }
        
        public void OnGet()
        {
            acudienteDesignado= _repoAcudiente.GetAllAcudientes();
        }
        
    }
}
