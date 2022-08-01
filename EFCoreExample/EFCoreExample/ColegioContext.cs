using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    internal class ColegioContext : DbContext
    {
        public DbSet<Estudiante>? Estudiantes { get; set; }
        public DbSet<Asignatura>? Asignaturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            string connection = "Server = tcp:efcoreexample.database.windows.net,1433;" +
                "Initial Catalog = EFCoreExample;" +
                "Persist Security Info = False;" +
                "User ID = EFCore;" +
                "Password = abc123.,;" +
                "MultipleActiveResultSets = False;" +
                "Encrypt = True;" +
                "TrustServerCertificate = False;" +
                "Connection Timeout = 30;";

            optionBuilder.UseSqlServer(connection);

        }
    }
}
