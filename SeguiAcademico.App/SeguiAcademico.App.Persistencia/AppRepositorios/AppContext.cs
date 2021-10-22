using Microsoft.EntityFrameworkCore;
using SeguiAcademico.App.Dominio;

namespace SeguiAcademico.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<AcudienteDesignado> AcudientesDesignados { get; set; }
        public DbSet<Historial> Historiales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=tcp:databaseappseguiacademico.database.windows.net,1433;Initial Catalog=SeguiAcademico;Persist Security Info=False;User ID=walther08;Password=@Kz_1104;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}