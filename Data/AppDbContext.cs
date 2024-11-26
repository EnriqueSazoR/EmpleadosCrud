// Esta clase interactua con la Bd, cada módelo que se cree, se debe 
// crear una instancia en esta clase.

using Microsoft.EntityFrameworkCore;
using MvcEmpleados.Models;

namespace MvcEmpleados.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        // Agregar Modelos
        public DbSet<Empleado> Empleados { get; set; }

    }
}