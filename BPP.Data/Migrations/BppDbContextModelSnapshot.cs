﻿// <auto-generated />
using BPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPP.Data.Migrations
{
    [DbContext(typeof(BppDbContext))]
    partial class BppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BPP.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "Telliler"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "Vurmalilar"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "Uflemeliler"
                        });
                });

            modelBuilder.Entity("BPP.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            IsActive = true,
                            Name = "Trampet",
                            Price = 120.50m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsActive = false,
                            Name = "Klasık Gıtar",
                            Price = 220.50m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsActive = true,
                            Name = "Elektro Gıtar",
                            Price = 137.53m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            IsActive = true,
                            Name = "Baglama",
                            Price = 99.50m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            IsActive = true,
                            Name = "Blok Flut",
                            Price = 15.50m,
                            Stock = 20
                        });
                });

            modelBuilder.Entity("BPP.Core.Models.Product", b =>
                {
                    b.HasOne("BPP.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BPP.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
