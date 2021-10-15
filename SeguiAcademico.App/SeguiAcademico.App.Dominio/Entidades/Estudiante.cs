using System;
using System.Collections.Generic;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class Estudiante:Persona
    {
        public string Curso {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public string MateriasInscritas { get; set; }
        //Entidades asociadas
        public List<Historial> Historiales { get; set; }
        public List<Maestro> Maestro { get; set; }
        public List<Tutor> Tutor { get; set; }
        public AcudienteDesignado AcudienteDesignado { get; set; }
    }
}