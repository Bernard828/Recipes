using Microsoft.EntityFrameworkCore.Migrations;

namespace api_collection.Migrations
{
    public partial class ImageNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodImage",
                value: "vegetables.jpg");

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FoodImage",
                value: "chicken.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodImage",
                value: "vegetables2.jpg");

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FoodImage",
                value: "chicken2.jpg");
        }
    }
}
