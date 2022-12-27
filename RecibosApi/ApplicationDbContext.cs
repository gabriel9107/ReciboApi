using Microsoft.EntityFrameworkCore;
using RecibosApi.Entidades;

namespace RecibosApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Miembros> Miembros { get; set; }
        public DbSet<Vehiculo> vehiculos { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<CodigoDePago> CodigoDePagos { get; set; }
        public DbSet<DetalleCodigoDePago> detalleCodigoDePagos { get; set; }

    }
}
