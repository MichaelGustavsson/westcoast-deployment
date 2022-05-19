using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles_API.Data.Migrations
{
    public partial class AddedcolumnsDescriptionandValuetoVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Vehicles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Vehicles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Vehicles");
        }
    }
}
