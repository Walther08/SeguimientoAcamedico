using System;

namespace SeguiAcademico.App.Dominio
{
    public class Recomendacion
    {
        public int RecomendacionId {get;set;}
        public DateTime FechaPublicacion {get; set;}
        public DateTime FechaEntrega {get; set;}
        public string Materia {get; set;}
        public string Tematica {get; set;}
        //Entidades asociadas
        public Maestro MaestroEncargado {get; set;}
        public TipoActividad TipoActividad {get; set;}
        public EstadoAvance EstadoAvance {get;set;}
        //¡Cómo se define que debe ir un documento adjunto (taller, tarea, actividad, etc.)?
    }
}