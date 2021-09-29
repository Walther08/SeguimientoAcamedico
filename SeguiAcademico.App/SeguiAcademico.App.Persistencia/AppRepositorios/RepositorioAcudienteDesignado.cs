using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;


namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioAcudienteDesignado : IRepositorioAcudienteDesignado
    {
        private readonly SeguiAcademico.App.Persistencia.AppContext _appContext;
        public RepositorioAcudienteDesignado(SeguiAcademico.App.Persistencia.AppContext appContext)
        {
            _appContext= appContext;
        }
        AcudienteDesignado IRepositorioAcudienteDesignado.AddAcudiente(AcudienteDesignado acudiente)
        {
            var acudienteAdicionado= _appContext.AcudientesDesignados.Add(acudiente);
            _appContext.SaveChanges();
            return acudienteAdicionado.Entity;
        }
        AcudienteDesignado IRepositorioAcudienteDesignado.UpdateAcudiente(AcudienteDesignado acudiente)
        {
            var acudienteEncontrado= _appContext.AcudientesDesignados.FirstOrDefault(a => a.Id == acudiente.Id);
            if(acudienteEncontrado!=null)
            {
                acudienteEncontrado.Nombre= acudiente.Nombre;
                acudienteEncontrado.Apellidos= acudiente.Apellidos;
                acudienteEncontrado.NumeroTelefono= acudiente.NumeroTelefono;
                acudienteEncontrado.Genero= acudiente.Genero;
                acudienteEncontrado.Parentesco= acudiente.Parentesco;
                acudienteEncontrado.CorreoElectronico= acudiente.CorreoElectronico;

                _appContext.SaveChanges();
                
            }

            return acudienteEncontrado;
        }
        void IRepositorioAcudienteDesignado.DeleteAcudiente(int IdAcudiente)
        {
            var acudienteEncontrado= _appContext.AcudientesDesignados.FirstOrDefault(a => a.Id == IdAcudiente);
            if(acudienteEncontrado==null)
            return;
            _appContext.AcudientesDesignados.Remove(acudienteEncontrado);
            _appContext.SaveChanges();
        }
        AcudienteDesignado IRepositorioAcudienteDesignado.GetAcudiente(int IdAcudiente)
        {
            var acudienteEncontrado= _appContext.AcudientesDesignados.FirstOrDefault(a => a.Id == IdAcudiente);
            return acudienteEncontrado;
        }
        IEnumerable<AcudienteDesignado> IRepositorioAcudienteDesignado.GetAllAcudiente()
        {
            return _appContext.AcudientesDesignados;
        }
                  
    }
}
