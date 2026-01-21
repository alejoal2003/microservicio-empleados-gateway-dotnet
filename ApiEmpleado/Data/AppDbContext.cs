using Microsoft.EntityFrameworkCore;
using ApiEmpleado.Models;

namespace ApiEmpleado.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasIndex(e => e.Cedula).IsUnique();
            });
        }
    }
}