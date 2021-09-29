using System.Collections.Generic;
using SeguiAcademico.App.Dominio;
using System.Linq;
using System;

namespace SeguiAcademico.App.Persistencia
{
    public class RepositorioTutor : IRepositorioTutor
    {
        private readonly AppContext _appContext = new AppContext();
        Tutor IRepositorioTutor.AddTutor(Tutor tutor)
        {
            var tutorAdicionado= _appContext.Tutores.Add(tutor);
            _appContext.SaveChanges();
            return tutorAdicionado.Entity;
        }
        Tutor IRepositorioTutor.UpdateTutor(Tutor tutor)
        {
            var tutorEncontrado= _appContext.Tutores.FirstOrDefault(t => t.Id == tutor.Id);
            if(tutorEncontrado!=null)
            {
                tutorEncontrado.Nombre= tutor.Nombre;
                tutorEncontrado.Apellidos= tutor.Apellidos;
                tutorEncontrado.NumeroTelefono= tutor.NumeroTelefono;
                tutorEncontrado.Genero= tutor.Genero;
                tutorEncontrado.MateriaTutoria= tutor.MateriaTutoria;
                tutorEncontrado.HorasLaborales= tutor.HorasLaborales;
                tutorEncontrado.CorreoInstitucional= tutor.CorreoInstitucional;

                _appContext.SaveChanges();
            }

            return tutorEncontrado;
        }
        void IRepositorioTutor.DeleteTutor(int IdTutor)
        {
            var tutorEncontrado= _appContext.Tutores.FirstOrDefault(t => t.Id == IdTutor);
            if(tutorEncontrado==null)
            return;
            _appContext.Tutores.Remove(tutorEncontrado);
            _appContext.SaveChanges();
        }
        Tutor IRepositorioTutor.GetTutor(int IdTutor)
        {
            var tutorEncontrado= _appContext.Tutores.FirstOrDefault(t => t.Id == IdTutor);
            return tutorEncontrado;
        }
        IEnumerable<Tutor> IRepositorioTutor.GetAllTutor()
        {
            return _appContext.Tutores;
        }
                  
    }
}