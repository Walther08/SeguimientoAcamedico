using System;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class AcudienteDesignado:Persona
    {
        public string Parentesco {get;set;}
        public string edad {get;set;}
        public string CorreoElectronico {get;set;}
    }
}