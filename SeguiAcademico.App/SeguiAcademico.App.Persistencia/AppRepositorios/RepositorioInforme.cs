using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;

namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioInforme : IRepositorioInforme
    {
        private readonly AppContext _appContext = new AppContext();
        
        Informe IRepositorioInforme.AddInforme(Informe informe)
        {
            var informeAdicionado= _appContext.Informe.Add(informe);
            _appContext.SaveChanges();
            return informeAdicionado.Entity;
        }
        Informe IRepositorioInforme.UpdateInforme(Informe informe)
        {
            var informeEncontrado= _appContext.Informe.FirstOrDefault(i => i.Id == informe.Id);
            if(informeEncontrado!=null)
            {
                informeEncontrado.Fecha= informe.Fecha;
                informeEncontrado.Materia= informe.Materia;
                informeEncontrado.Asunto= informe.Asunto;
                informeEncontrado.Descripcion= informe.Descripcion;

                _appContext.SaveChanges();
                
            }

            return informeEncontrado;
        }

        void IRepositorioInforme.DeleteInforme(int IdInforme)
        {
            var informeEncontrado= _appContext.Informe.FirstOrDefault(i => i.Id == IdInforme);
            if(informeEncontrado==null)
            return;
            _appContext.Informe.Remove(informeEncontrado);
            _appContext.SaveChanges();
        }

        Informe IRepositorioInforme.GetInforme(int IdInforme)
        {
            var informeEncontrado= _appContext.Informe.FirstOrDefault(i => i.Id == IdInforme);
            return informeEncontrado;
        }

        IEnumerable<Informe> IRepositorioInforme.GetAllInformes()
        {
            return _appContext.Informe;
        } 
                  
    }
}
