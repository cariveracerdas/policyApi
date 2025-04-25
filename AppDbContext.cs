namespace policyApi
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using policyApi.Models;

    public class AppDbContext : DbContext
    {
        public DbSet<ClienteModelEntity> Clientes { get; set; }
        public DbSet<TipoPolizaModelEntity> TipoPolizas { get; set; }
        public DbSet<EstadoPolizaModelEntity> EstadoPolizas { get; set; }
        public DbSet<CoberturaModelEntity> Coberturas { get; set; }
        public DbSet<PolizaModelEntity> Polizas { get; set; }
        public DbSet<UsuarioModelEntity> Usuarios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolizaModelEntity>()
                .HasIndex(p => p.NumeroPoliza)
                .IsUnique();


            modelBuilder.Entity<PolizaModelEntity>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Polizas)
                .HasForeignKey(p => p.CedulaAsegurado)
                .HasPrincipalKey(c => c.CedulaAsegurado)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PolizaModelEntity>()
                .HasOne(p => p.TipoPoliza)
                .WithMany(c => c.Polizas)
                .HasForeignKey(p => p.IdTipoPoliza)
                .HasPrincipalKey(c => c.IdTipoPoliza)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PolizaModelEntity>()
                  .HasOne(p => p.EstadoPoliza)
                  .WithMany(c => c.Polizas)
                  .HasForeignKey(p => p.IdEstadoPoliza)
                  .HasPrincipalKey(c => c.IdEstado)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PolizaModelEntity>()
                 .HasOne(p => p.Cobertura)
                 .WithMany(c => c.Polizas)
                 .HasForeignKey(p => p.IdCobertura)
                 .HasPrincipalKey(c => c.IdCobertura)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UsuarioModelEntity>().HasData(
                new UsuarioModelEntity
                {
                    Id = 1,
                    Username = "popularTec",
                    Password = "AQAAAAIAAYagAAAAEE/IAxx/nu20yoha5kwGHh05oNnURMr/F93BLL8eUTmPc2/jBBmxPkl5rECazc2kpA=="
                }
            );

            modelBuilder.Entity<EstadoPolizaModelEntity>().HasData(
                new EstadoPolizaModelEntity { IdEstado = 1, Nombre = "Vigente", Activo = true },
                new EstadoPolizaModelEntity { IdEstado = 2, Nombre = "Vencida", Activo = true },
                new EstadoPolizaModelEntity { IdEstado = 3, Nombre = "Cancelada", Activo = true }
            );

            modelBuilder.Entity<TipoPolizaModelEntity>().HasData(
                new TipoPolizaModelEntity { IdTipoPoliza = 1, Nombre = "Vida", Activo = true },
                new TipoPolizaModelEntity { IdTipoPoliza = 2, Nombre = "Automóvil", Activo = true },
                new TipoPolizaModelEntity { IdTipoPoliza = 3, Nombre = "Terceros", Activo = true }
            );

            modelBuilder.Entity<CoberturaModelEntity>().HasData(
                new CoberturaModelEntity { IdCobertura = 1, Nombre = "Básica", Activo = true },
                new CoberturaModelEntity { IdCobertura = 2, Nombre = "Completa", Activo = true },
                new CoberturaModelEntity { IdCobertura = 3, Nombre = "Pérdida", Activo = true },
                new CoberturaModelEntity { IdCobertura = 4, Nombre = "Vencimiento", Activo = true }
            );
            modelBuilder.Entity<ClienteModelEntity>().HasData(
                  new ClienteModelEntity
                  {
                      CedulaAsegurado = "101010101",
                      Nombre = "Cristopher",
                      PrimerApellido = "Rivera",
                      SegundoApellido = "Cerdas",
                      TipoPersona = "Fisica",
                      FechaNacimiento = new DateTime(1995, 4, 20)
                  },
                  new ClienteModelEntity
                  {
                      CedulaAsegurado = "202020202",
                      Nombre = "Jose",
                      PrimerApellido = "Ramirez",
                      SegundoApellido = "Mora",
                      TipoPersona = "Fisica",
                      FechaNacimiento = new DateTime(1990, 6, 15)
                  },
                  new ClienteModelEntity
                  {
                      CedulaAsegurado = "303030303",
                      Nombre = "Ramon",
                      PrimerApellido = "Chaves",
                      SegundoApellido = "Lopez",
                      TipoPersona = "Fisica",
                      FechaNacimiento = new DateTime(1985, 3, 8)
                  }
              );

            base.OnModelCreating(modelBuilder);
        }
    }
}
