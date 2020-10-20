﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    [Migration("20201002034609_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "ASH",
                            Name = "Aseo Hogar"
                        },
                        new
                        {
                            CategoryId = "ASP",
                            Name = "Aseo Personal"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.Property<string>("InOutId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StorageEntityStoregeId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InOutId");

                    b.HasIndex("StorageEntityStoregeId");

                    b.ToTable("InputOutputs");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("StoregeId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WerehouseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WerehousesWerehouseId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StoregeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WerehousesWerehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WerehouseEntity", b =>
                {
                    b.Property<string>("WerehouseId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WerehouseAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WerehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("WerehouseId");

                    b.ToTable("Werehouses");

                    b.HasData(
                        new
                        {
                            WerehouseId = "89cdc7ed-5050-47c9-ac9b-4ed42efb6801",
                            WerehouseAddress = "Av evergreen No. 704",
                            WerehouseName = "Bodega Celtral"
                        },
                        new
                        {
                            WerehouseId = "3dcaddd1-2417-464e-bfaf-e6ad8e7ad7b9",
                            WerehouseAddress = "Calle falsa 123",
                            WerehouseName = "Bodega Norte"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", null)
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageEntityStoregeId");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("Entities.WerehouseEntity", "Werehouses")
                        .WithMany("Storages")
                        .HasForeignKey("WerehousesWerehouseId");
                });
#pragma warning restore 612, 618
        }
    }
}