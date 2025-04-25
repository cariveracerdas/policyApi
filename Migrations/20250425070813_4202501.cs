using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class _4202501 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Clientes_ClienteCedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaIdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaIdEstado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.RenameColumn(
                name: "TipoPolizaIdTipoPoliza",
                table: "Polizas",
                newName: "TipoPolizaModelEntityIdTipoPoliza");

            migrationBuilder.RenameColumn(
                name: "EstadoPolizaIdEstado",
                table: "Polizas",
                newName: "EstadoPolizaModelEntityIdEstado");

            migrationBuilder.RenameColumn(
                name: "CoberturaIdCobertura",
                table: "Polizas",
                newName: "CoberturaModelEntityIdCobertura");

            migrationBuilder.RenameColumn(
                name: "ClienteCedulaAsegurado",
                table: "Polizas",
                newName: "ClienteModelEntityCedulaAsegurado");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_TipoPolizaIdTipoPoliza",
                table: "Polizas",
                newName: "IX_Polizas_TipoPolizaModelEntityIdTipoPoliza");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_EstadoPolizaIdEstado",
                table: "Polizas",
                newName: "IX_Polizas_EstadoPolizaModelEntityIdEstado");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_CoberturaIdCobertura",
                table: "Polizas",
                newName: "IX_Polizas_CoberturaModelEntityIdCobertura");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_ClienteCedulaAsegurado",
                table: "Polizas",
                newName: "IX_Polizas_ClienteModelEntityCedulaAsegurado");

            migrationBuilder.AlterColumn<string>(
                name: "CedulaAsegurado",
                table: "Polizas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_CedulaAsegurado",
                table: "Polizas",
                column: "CedulaAsegurado");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdCobertura",
                table: "Polizas",
                column: "IdCobertura");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdEstadoPoliza",
                table: "Polizas",
                column: "IdEstadoPoliza");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdTipoPoliza",
                table: "Polizas",
                column: "IdTipoPoliza");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Clientes_CedulaAsegurado",
                table: "Polizas",
                column: "CedulaAsegurado",
                principalTable: "Clientes",
                principalColumn: "CedulaAsegurado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Clientes_ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                column: "ClienteModelEntityCedulaAsegurado",
                principalTable: "Clientes",
                principalColumn: "CedulaAsegurado");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaModelEntityIdCobertura",
                table: "Polizas",
                column: "CoberturaModelEntityIdCobertura",
                principalTable: "Coberturas",
                principalColumn: "IdCobertura");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_IdCobertura",
                table: "Polizas",
                column: "IdCobertura",
                principalTable: "Coberturas",
                principalColumn: "IdCobertura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                column: "EstadoPolizaModelEntityIdEstado",
                principalTable: "EstadoPolizas",
                principalColumn: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_EstadoPolizas_IdEstadoPoliza",
                table: "Polizas",
                column: "IdEstadoPoliza",
                principalTable: "EstadoPolizas",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_TipoPolizas_IdTipoPoliza",
                table: "Polizas",
                column: "IdTipoPoliza",
                principalTable: "TipoPolizas",
                principalColumn: "IdTipoPoliza",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                column: "TipoPolizaModelEntityIdTipoPoliza",
                principalTable: "TipoPolizas",
                principalColumn: "IdTipoPoliza");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Clientes_CedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Clientes_ClienteModelEntityCedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaModelEntityIdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_IdCobertura",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_EstadoPolizas_IdEstadoPoliza",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_IdTipoPoliza",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_TipoPolizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_CedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_IdCobertura",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_IdEstadoPoliza",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_IdTipoPoliza",
                table: "Polizas");

            migrationBuilder.RenameColumn(
                name: "TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                newName: "TipoPolizaIdTipoPoliza");

            migrationBuilder.RenameColumn(
                name: "EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                newName: "EstadoPolizaIdEstado");

            migrationBuilder.RenameColumn(
                name: "CoberturaModelEntityIdCobertura",
                table: "Polizas",
                newName: "CoberturaIdCobertura");

            migrationBuilder.RenameColumn(
                name: "ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                newName: "ClienteCedulaAsegurado");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_TipoPolizaModelEntityIdTipoPoliza",
                table: "Polizas",
                newName: "IX_Polizas_TipoPolizaIdTipoPoliza");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_EstadoPolizaModelEntityIdEstado",
                table: "Polizas",
                newName: "IX_Polizas_EstadoPolizaIdEstado");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_CoberturaModelEntityIdCobertura",
                table: "Polizas",
                newName: "IX_Polizas_CoberturaIdCobertura");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                newName: "IX_Polizas_ClienteCedulaAsegurado");

            migrationBuilder.AlterColumn<string>(
                name: "CedulaAsegurado",
                table: "Polizas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Clientes_ClienteCedulaAsegurado",
                table: "Polizas",
                column: "ClienteCedulaAsegurado",
                principalTable: "Clientes",
                principalColumn: "CedulaAsegurado");

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
    }
}
