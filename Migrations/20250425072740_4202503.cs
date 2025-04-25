using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class _4202503 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaModelEntityIdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_CoberturaModelEntityIdCobertura",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "CoberturaModelEntityIdCobertura",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "EstadoPolizaModelEntityIdEstado",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoberturaModelEntityIdCobertura",
                table: "Polizas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_CoberturaModelEntityIdCobertura",
                table: "Polizas",
                column: "CoberturaModelEntityIdCobertura");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                column: "EstadoPolizaModelEntityIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaModelEntityIdTipoPoliza");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaModelEntityIdCobertura",
                table: "Polizas",
                column: "CoberturaModelEntityIdCobertura",
                principalTable: "Coberturas",
                principalColumn: "IdCobertura");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                column: "EstadoPolizaModelEntityIdEstado",
                principalTable: "EstadoPolizas",
                principalColumn: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaModelEntityIdTipoPoliza",
                principalTable: "TipoPolizas",
                principalColumn: "IdTipoPoliza");
        }
    }
}
