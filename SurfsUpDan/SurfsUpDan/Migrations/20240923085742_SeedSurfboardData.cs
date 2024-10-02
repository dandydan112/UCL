using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUpDan.Migrations
{
    /// <inheritdoc />
    public partial class SeedSurfboardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "Surfboards",
                columns: new[] { "SurfboardId", "Equipment", "Length", "Name", "PricePerDay", "Thickness", "Type", "Volume", "Width" },
                values: new object[] { 1, "Leash, Fins", 9f, "Classic Longboard", 50.0m, 3f, "Longboard", 72f, 22.5f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Surfboards",
                keyColumn: "SurfboardId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
