using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CedulaAsegurado = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CedulaAsegurado);
                });

            migrationBuilder.CreateTable(
                name: "Coberturas",
                columns: table => new
                {
                    IdCobertura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coberturas", x => x.IdCobertura);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPolizas",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPolizas", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "TipoPolizas",
                columns: table => new
                {
                    IdTipoPoliza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPolizas", x => x.IdTipoPoliza);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    IdPoliza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPoliza = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MontoAsegurado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Periodo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInclusion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CedulaAsegurado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteCedulaAsegurado = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdTipoPoliza = table.Column<int>(type: "int", nullable: false),
                    TipoPolizaIdTipoPoliza = table.Column<int>(type: "int", nullable: false),
                    IdEstadoPoliza = table.Column<int>(type: "int", nullable: false),
                    EstadoPolizaIdEstado = table.Column<int>(type: "int", nullable: false),
                    IdCobertura = table.Column<int>(type: "int", nullable: false),
                    CoberturaIdCobertura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.IdPoliza);
                    table.ForeignKey(
                        name: "FK_Polizas_Clientes_ClienteCedulaAsegurado",
                        column: x => x.ClienteCedulaAsegurado,
                        principalTable: "Clientes",
                        principalColumn: "CedulaAsegurado");
                    table.ForeignKey(
                        name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                        column: x => x.CoberturaIdCobertura,
                        principalTable: "Coberturas",
                        principalColumn: "IdCobertura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                        column: x => x.EstadoPolizaIdEstado,
                        principalTable: "EstadoPolizas",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                        column: x => x.TipoPolizaIdTipoPoliza,
                        principalTable: "TipoPolizas",
                        principalColumn: "IdTipoPoliza",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_ClienteCedulaAsegurado",
                table: "Polizas",
                column: "ClienteCedulaAsegurado");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_CoberturaIdCobertura",
                table: "Polizas",
                column: "CoberturaIdCobertura");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_EstadoPolizaIdEstado",
                table: "Polizas",
                column: "EstadoPolizaIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_NumeroPoliza",
                table: "Polizas",
                column: "NumeroPoliza",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_TipoPolizaIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaIdTipoPoliza");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Coberturas");

            migrationBuilder.DropTable(
                name: "EstadoPolizas");

            migrationBuilder.DropTable(
                name: "TipoPolizas");
        }
    }
}
