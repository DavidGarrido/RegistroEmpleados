using Microsoft.EntityFrameworkCore;

namespace RegistroEmpleados.Modelos
{
    public class aplicationDbContext:DbContext
    {
        public aplicationDbContext(DbContextOptions<aplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Salario> Salario { get; set; }
    }
}
