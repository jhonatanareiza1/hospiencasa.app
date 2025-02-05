using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> FamiliaresDesignados { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidados { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=HospiEnCasa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Historia>()
                .HasKey(h => h.IdHistoria); // Define 'Id' como clave primaria.

            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<SignoVital>()
                .HasKey(s => s.IdSignoVital); // Define 'Id' como clave primaria.

            base.OnModelCreating(modelBuilder);
        }


    }
}