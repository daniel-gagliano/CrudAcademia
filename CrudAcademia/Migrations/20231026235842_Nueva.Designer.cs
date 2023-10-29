﻿// <auto-generated />
using System;
using CrudAcademia.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudAcademia.Migrations
{
    [DbContext(typeof(AcademiaContext))]
    [Migration("20231026235842_Nueva")]
    partial class Nueva
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BibliotecaClases.Especialidad", b =>
                {
                    b.Property<int>("idEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEspecialidad"));

                    b.Property<string>("descEspecialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEspecialidad");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("BibliotecaClases.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPlan")
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("legajo")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("BibliotecaClases.Plan", b =>
                {
                    b.Property<int>("idPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPlan"));

                    b.Property<string>("descPlan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEspecialidad")
                        .HasColumnType("int");

                    b.HasKey("idPlan");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("BibliotecaClases.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<int>("idPersona")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
