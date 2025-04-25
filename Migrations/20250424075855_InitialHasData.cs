using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialHasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coberturas",
                columns: new[] { "IdCobertura", "Activo", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Básica" },
                    { 2, true, "Completa" },
                    { 3, true, "Pérdida" },
                    { 4, true, "Vencimiento" }
                });

            migrationBuilder.InsertData(
                table: "EstadoPolizas",
                columns: new[] { "IdEstado", "Activo", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Vigente" },
                    { 2, true, "Vencida" },
                    { 3, true, "Cancelada" }
                });

            migrationBuilder.InsertData(
                table: "TipoPolizas",
                columns: new[] { "IdTipoPoliza", "Activo", "Nombre" },
                values: new object[,]
                {
                    { 1, true, "Vida" },
                    { 2, true, "Automóvil" },
                    { 3, true, "Terceros" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "AQAAAAIAAYagAAAAEJ2QS+1EfGQ054RYP10603NofwbI+PYtJbb0YMK+l5/i/IEojMxYFOu9c5KqbPGHSw==", "popularTec" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DeleteData(
                table: "Coberturas",
                keyColumn: "IdCobertura",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coberturas",
                keyColumn: "IdCobertura",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coberturas",
                keyColumn: "IdCobertura",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coberturas",
                keyColumn: "IdCobertura",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EstadoPolizas",
                keyColumn: "IdEstado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoPolizas",
                keyColumn: "IdEstado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EstadoPolizas",
                keyColumn: "IdEstado",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoPolizas",
                keyColumn: "IdTipoPoliza",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoPolizas",
                keyColumn: "IdTipoPoliza",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoPolizas",
                keyColumn: "IdTipoPoliza",
                keyValue: 3);
        }
    }
}
