using System;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class Tutor:Persona
    {
        public string MateriaTutoria {get;set;}
        public int HorasLaborales {get;set;}
        public string CorreoInstitucional {get;set;}

    }
}