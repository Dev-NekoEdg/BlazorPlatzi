using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext:DbContext
    {
        public InventaryContext()
        {

        }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WerehouseEntity> Werehouses { get; set; }

    }
}
