
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiInventario.Dominio.Entidades;

namespace WebApiInventario.Infraestructura.Data
{
    public class InventarioDbContext : DbContext
    {
        public InventarioDbContext(DbContextOptions<InventarioDbContext> options)
        : base(options){}

        public DbSet<Producto> Productos { get; set; }

    }
}
