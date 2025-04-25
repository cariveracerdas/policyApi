using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace policyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialHasDataLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "5c7e27b720271b9d39116dcfd3bd241b4a0e67ecf2245a692579e124e5d81807");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEJ2QS+1EfGQ054RYP10603NofwbI+PYtJbb0YMK+l5/i/IEojMxYFOu9c5KqbPGHSw==");
        }
    }
}
