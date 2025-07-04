﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using policyApi;

#nullable disable

namespace policyApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250424075855_InitialHasData")]
    partial class InitialHasData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("policyApi.Models.ClienteModelEntity", b =>
                {
                    b.Property<string>("CedulaAsegurado")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CedulaAsegurado");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("policyApi.Models.CoberturaModelEntity", b =>
                {
                    b.Property<int>("IdCobertura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCobertura"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCobertura");

                    b.ToTable("Coberturas");

                    b.HasData(
                        new
                        {
                            IdCobertura = 1,
                            Activo = true,
                            Nombre = "Básica"
                        },
                        new
                        {
                            IdCobertura = 2,
                            Activo = true,
                            Nombre = "Completa"
                        },
                        new
                        {
                            IdCobertura = 3,
                            Activo = true,
                            Nombre = "Pérdida"
                        },
                        new
                        {
                            IdCobertura = 4,
                            Activo = true,
                            Nombre = "Vencimiento"
                        });
                });

            modelBuilder.Entity("policyApi.Models.EstadoPolizaModelEntity", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstado");

                    b.ToTable("EstadoPolizas");

                    b.HasData(
                        new
                        {
                            IdEstado = 1,
                            Activo = true,
                            Nombre = "Vigente"
                        },
                        new
                        {
                            IdEstado = 2,
                            Activo = true,
                            Nombre = "Vencida"
                        },
                        new
                        {
                            IdEstado = 3,
                            Activo = true,
                            Nombre = "Cancelada"
                        });
                });

            modelBuilder.Entity("policyApi.Models.PolizaModelEntity", b =>
                {
                    b.Property<int>("IdPoliza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPoliza"));

                    b.Property<string>("Aseguradora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CedulaAsegurado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClienteCedulaAsegurado")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CoberturaIdCobertura")
                        .HasColumnType("int");

                    b.Property<int>("EstadoPolizaIdEstado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInclusion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCobertura")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoPoliza")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPoliza")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoAsegurado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NumeroPoliza")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Periodo")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Prima")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoPolizaIdTipoPoliza")
                        .HasColumnType("int");

                    b.HasKey("IdPoliza");

                    b.HasIndex("ClienteCedulaAsegurado");

                    b.HasIndex("CoberturaIdCobertura");

                    b.HasIndex("EstadoPolizaIdEstado");

                    b.HasIndex("NumeroPoliza")
                        .IsUnique();

                    b.HasIndex("TipoPolizaIdTipoPoliza");

                    b.ToTable("Polizas");
                });

            modelBuilder.Entity("policyApi.Models.TipoPolizaModelEntity", b =>
                {
                    b.Property<int>("IdTipoPoliza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPoliza"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoPoliza");

                    b.ToTable("TipoPolizas");

                    b.HasData(
                        new
                        {
                            IdTipoPoliza = 1,
                            Activo = true,
                            Nombre = "Vida"
                        },
                        new
                        {
                            IdTipoPoliza = 2,
                            Activo = true,
                            Nombre = "Automóvil"
                        },
                        new
                        {
                            IdTipoPoliza = 3,
                            Activo = true,
                            Nombre = "Terceros"
                        });
                });

            modelBuilder.Entity("policyApi.Models.UsuarioModelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "AQAAAAIAAYagAAAAEJ2QS+1EfGQ054RYP10603NofwbI+PYtJbb0YMK+l5/i/IEojMxYFOu9c5KqbPGHSw==",
                            Username = "popularTec"
                        });
                });

            modelBuilder.Entity("policyApi.Models.PolizaModelEntity", b =>
                {
                    b.HasOne("policyApi.Models.ClienteModelEntity", "Cliente")
                        .WithMany("Polizas")
                        .HasForeignKey("ClienteCedulaAsegurado");

                    b.HasOne("policyApi.Models.CoberturaModelEntity", "Cobertura")
                        .WithMany("Polizas")
                        .HasForeignKey("CoberturaIdCobertura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("policyApi.Models.EstadoPolizaModelEntity", "EstadoPoliza")
                        .WithMany("Polizas")
                        .HasForeignKey("EstadoPolizaIdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("policyApi.Models.TipoPolizaModelEntity", "TipoPoliza")
                        .WithMany("Polizas")
                        .HasForeignKey("TipoPolizaIdTipoPoliza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Cobertura");

                    b.Navigation("EstadoPoliza");

                    b.Navigation("TipoPoliza");
                });

            modelBuilder.Entity("policyApi.Models.ClienteModelEntity", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("policyApi.Models.CoberturaModelEntity", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("policyApi.Models.EstadoPolizaModelEntity", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("policyApi.Models.TipoPolizaModelEntity", b =>
                {
                    b.Navigation("Polizas");
                });
#pragma warning restore 612, 618
        }
    }
}
