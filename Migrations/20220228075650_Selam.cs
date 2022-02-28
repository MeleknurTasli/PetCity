using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCity.Migrations
{
    public partial class Selam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestPropInt",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestPropString",
                table: "Products",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestPropInt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TestPropString",
                table: "Products");
        }
    }
}
