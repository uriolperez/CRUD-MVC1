﻿// <auto-generated />
using CRUD_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250412190845_SeedCategory")]
    partial class SeedCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_MVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coca Cola",
                            Price = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Inka Cola",
                            Price = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fanta",
                            Price = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sprite",
                            Price = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Coca",
                            Price = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
