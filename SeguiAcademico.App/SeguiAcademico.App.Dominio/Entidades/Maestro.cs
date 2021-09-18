using System;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class Maestro:Persona
    {
        public string Materia {get;set;}
        public string CorreoInstitucional {get;set;}
        public string CursoACargo {get;set;} //Confirmar la forma de listar y seleccionar los cursos para asociar más de un elemento
    }
}