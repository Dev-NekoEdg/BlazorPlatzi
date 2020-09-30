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

        /*
         Este método se configura la cadena de conexion para la DB. no voy a utilizar este método aquí, sino que lo voy a inyectar desde el startup.cs.
         El middleware de "UseSqlServer()" se puede usar luego de instalar el paquete "Microsoft.EntityframeworkCore.SqlServer".
         */
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=DESKTOP-8EL03UO\\SQLEXPRESS; Database = Corresponsal; User Id =sa; Password=SqlEx2020*");
        //    }
        //}

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WerehouseEntity> Werehouses { get; set; }

    }
}
