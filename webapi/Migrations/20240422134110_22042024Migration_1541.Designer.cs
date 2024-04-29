﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.BazarDaElioDb;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(BazarDaElioContext))]
    [Migration("20240422134110_22042024Migration_1541")]
    partial class _22042024Migration_1541
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.BazarDaElioDb.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NumeroCategoria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("webapi.BazarDaElioDb.Elettronica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Materiale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modello")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Elettronica", (string)null);
                });

            modelBuilder.Entity("webapi.BazarDaElioDb.Maschere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Materiale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modello")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maschere", (string)null);
                });

            modelBuilder.Entity("webapi.BazarDaElioDb.Ombrelloni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Materiale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modello")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ombrelloni", (string)null);
                });

            modelBuilder.Entity("webapi.BazarDaElioDb.ScarpetteScogli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modello")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ScarpetteScogli", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}