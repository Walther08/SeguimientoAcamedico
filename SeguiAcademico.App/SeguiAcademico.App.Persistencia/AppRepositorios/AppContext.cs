using Microsoft.EntityFrameworkCore;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Informe> Informe {get; set;}
        public DbSet<Persona> Personas {get; set;} 
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Maestro> Maestros {get; set;}
        public DbSet<Tutor> Tutores {get; set;}
        public DbSet<AcudienteDesignado> AcudientesDesignados {get; set;}
        public DbSet<Historial> Historial {get; set;}
        public DbSet<Recomendacion> RecomendacionAcademica {get;set;}

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SeguiAcademico.Data");
                }
            }
    }
}