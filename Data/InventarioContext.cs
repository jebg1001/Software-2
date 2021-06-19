using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql.EntityFrameworkCore.PostgreSQL;
namespace Software_2.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options)
            :base(options)
            {
            }

                public DbSet<Software_2.Models.Producto> Productos { get; set; }
                public DbSet<Software_2.Models.Registrar> Registrar { get; set; }
                public DbSet<Software_2.Models.RegistroS> RegistroS { get; set; }
                public DbSet<Software_2.Models.ProductoH> RegistrarH { get; set; }
                public DbSet<Software_2.Models.ProductoM> RegistrarM { get; set; }
                public DbSet<Software_2.Models.ProductoN> RegistrarN { get; set; }
                public DbSet<Software_2.Models.EntradaProducto> EntradaProductos { get; set; }
                public DbSet<Software_2.Models.Cliente> Cliente { get; set; }

    }
}