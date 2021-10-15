using System;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class Maestro:Persona
    {
        public string Materia {get;set;}
        public string CorreoInstitucional {get;set;}
        public string CursoACargo {get;set;}
    }
}