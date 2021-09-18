using System;

namespace SeguiAcademico.App.Dominio
{
    //Herencia de Entidad Persona
    public class Estudiante:Persona
    {
        public string Curso {get;set;}
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public string MateriasInscritas {get;set;} //Confirmar la forma de listar y seleccionar las materias para asociar más de un elemento
        //Entidades asociadas
        public AcudienteDesignado AcudienteDesignado {get;set;}
        public Maestro Maestro {get;set;}
        public Tutor Tutor {get;set;}
        public Historial Historial {get;set;}
    }
}