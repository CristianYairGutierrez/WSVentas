using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Data.Entities;

namespace WSVentas.Data
{
    public class VentasDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Concepto> Conceptos { get; set; }

        public VentasDbContext(DbContextOptions<VentasDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 1,
                Nombre = "Cristian"
            }, new Cliente
            {
                Id = 2,
                Nombre = "Fister"
            });
        }
    }
}
