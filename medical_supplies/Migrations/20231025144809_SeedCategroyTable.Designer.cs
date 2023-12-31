﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using medical_supplies.Data;

#nullable disable

namespace medical_supplies.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231025144809_SeedCategroyTable")]
    partial class SeedCategroyTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("medical_supplies.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplyOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "new baby less than 2 month",
                            DisplyOrder = 1,
                            Name = "New born"
                        },
                        new
                        {
                            Id = 2,
                            Description = "babies between 2m-13y",
                            DisplyOrder = 2,
                            Name = "children"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            DisplyOrder = 3,
                            Name = "Band aid"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
