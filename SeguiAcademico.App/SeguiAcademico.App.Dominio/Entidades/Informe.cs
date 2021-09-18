using System;

namespace SeguiAcademico.App.Dominio
{
    //Informe realizado por el AcudienteDesignado
    public class Informe
    {
        public int InformeId {get;set;}
        public DateTime Fecha {get;set;}
        public string Materia {get;set;}
        public string Asunto {get;set;}
        public string Descripcion {get;set;}
    }
}