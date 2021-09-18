using System;

namespace SeguiAcademico.App.Dominio
{
    //Historial academico del estudiante
    public class Historial
    {
        public int HistorialId {get;set;}
        public string Observaciones {get;set;}
        //Entidades asociadas
        public Recomendacion RecomendacionAcademica {get;set;}
        public Informe InformeSeguimiento {get;set;}
        
    }
}