using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext:DbContext
    {
        /*
         Con el constructor de esta forma podemos inyectar el contexto desde la aplicación.
         Y podemos obtener la cadena de conexión desde el appsettings.json.
         */
        public InventaryContext(DbContextOptions<InventaryContext> options) : base(options)
        {

        }

        public InventaryContext()
        {
        }

        /*
         Este método se configura la cadena de conexion para la DB. no voy a utilizar este método aquí, sino que lo voy a inyectar desde el startup.cs.
         El middleware de "UseSqlServer()" se puede usar luego de instalar el paquete "Microsoft.EntityframeworkCore.SqlServer".
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-2L4PD83; Database=Inventary; User Id=Inventary; Password=Inventary");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", Name = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", Name = "Aseo Personal" });

            modelBuilder.Entity<WerehouseEntity>().HasData(
                new WerehouseEntity
                {
                    WerehouseId = Guid.NewGuid().ToString(),
                    WerehouseName = "Bodega Celtral",
                    WerehouseAddress = "Av evergreen No. 704"
                },
                new WerehouseEntity
                {
                    WerehouseId = Guid.NewGuid().ToString(),
                    WerehouseName = "Bodega Norte",
                    WerehouseAddress = "Calle falsa 123"
                }
                );
        }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WerehouseEntity> Werehouses { get; set; }

    }
}
