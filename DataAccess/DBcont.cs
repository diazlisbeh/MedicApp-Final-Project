using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DBcont:DbContext
    {

        public virtual DbSet<consultas> consultas { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<medicos> medicos { get; set; }
        public virtual DbSet<pacientes> pacientes { get; set; }
        public virtual DbSet<periodo_vacaciones> periodo_vacaciones { get; set; }
        public virtual DbSet<sustitutos> sustitutos { get; set; }
        public virtual DbSet<tipo_empleado> tipo_empleados { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}