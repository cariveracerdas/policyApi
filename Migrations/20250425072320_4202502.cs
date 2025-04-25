using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class _4202502 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Clientes_ClienteModelEntityCedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Polizas_ClienteModelEntityCedulaAsegurado",
                table: "Polizas");

            migrationBuilder.DropColumn(
                name: "ClienteModelEntityCedulaAsegurado",
                table: "Polizas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                column: "ClienteModelEntityCedulaAsegurado");

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Clientes_ClienteModelEntityCedulaAsegurado",
                table: "Polizas",
                column: "ClienteModelEntityCedulaAsegurado",
                principalTable: "Clientes",
                principalColumn: "CedulaAsegurado");
        }
    }
}
