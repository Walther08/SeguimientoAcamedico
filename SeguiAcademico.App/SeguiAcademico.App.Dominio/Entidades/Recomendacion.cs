using System;
using System.Collections.Generic;


namespace SeguiAcademico.App.Dominio
{
    public class Recomendacion
    {
        public int Id {get;set;}
        public DateTime FechaPublicacion {get; set;}
        public DateTime FechaEntrega {get; set;}
        public string Materia {get; set;}
        public string Tematica {get; set;}
        //Entidades asociadas
        public TipoActividad TipoActividad {get; set;}
        public EstadoAvance EstadoAvance {get;set;}
        
    }
}