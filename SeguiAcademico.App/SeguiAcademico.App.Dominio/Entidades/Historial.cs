using System;
using System.Collections.Generic;

namespace SeguiAcademico.App.Dominio
{
    //Historial academico del estudiante
    public class Historial
    {
        public int HistorialId {get;set;}
        public string Observaciones {get;set;}
        //Entidades asociadas
        public List<Recomendacion> RecomendacionAcademica {get;set;}
        
    }
}