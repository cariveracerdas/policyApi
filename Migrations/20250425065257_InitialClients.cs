using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPolizaIdTipoPoliza",
                table: "Polizas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoPolizaIdEstado",
                table: "Polizas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CoberturaIdCobertura",
                table: "Polizas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Polizas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "CedulaAsegurado", "FechaNacimiento", "Nombre", "PrimerApellido", "SegundoApellido", "TipoPersona" },
                values: new object[,]
                {
                    { "101010101", new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristopher", "Rivera", "Cerdas", "Fisica" },
                    { "202020202", new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jose", "Ramirez", "Mora", "Fisica" },
                    { "303030303", new DateTime(1985, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramon", "Chaves", "Lopez", "Fisica" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEE/IAxx/nu20yoha5kwGHh05oNnURMr/F93BLL8eUTmPc2/jBBmxPkl5rECazc2kpA==");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                table: "Polizas",
                column: "CoberturaIdCobertura",
                principalTable: "Coberturas",
                principalColumn: "IdCobertura");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                table: "Polizas",
                column: "EstadoPolizaIdEstado",
                principalTable: "EstadoPolizas",
                principalColumn: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaIdTipoPoliza",
                principalTable: "TipoPolizas",
                principalColumn: "IdTipoPoliza");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "CedulaAsegurado",
                keyValue: "101010101");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "CedulaAsegurado",
                keyValue: "202020202");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "CedulaAsegurado",
                keyValue: "303030303");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Polizas");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPolizaIdTipoPoliza",
                table: "Polizas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstadoPolizaIdEstado",
                table: "Polizas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoberturaIdCobertura",
                table: "Polizas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "5c7e27b720271b9d39116dcfd3bd241b4a0e67ecf2245a692579e124e5d81807");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                table: "Polizas",
                column: "CoberturaIdCobertura",
                principalTable: "Coberturas",
                principalColumn: "IdCobertura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                table: "Polizas",
                column: "EstadoPolizaIdEstado",
                principalTable: "EstadoPolizas",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaIdTipoPoliza",
                principalTable: "TipoPolizas",
                principalColumn: "IdTipoPoliza",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
