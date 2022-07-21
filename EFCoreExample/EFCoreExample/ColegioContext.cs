using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    internal class ColegioContext : DbContext
    {
        public DbSet<Estudiante>? Estudiantes { get; set; }
        public DbSet<Asignatura>? Asignaturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            string connection = "Data Source=.;" +
                "Initial Catalog = Colegio;" +
                "Integrated Security = true;" +
                "MultipleActiveResultSets = true;";

            optionBuilder.UseSqlServer(connection);

        }
    }
}
