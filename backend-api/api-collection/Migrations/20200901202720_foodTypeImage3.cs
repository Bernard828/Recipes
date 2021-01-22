using Microsoft.EntityFrameworkCore.Migrations;

namespace api_collection.Migrations
{
    public partial class foodTypeImage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodImage",
                value: "vegetables2.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodImage",
                value: "veggies.jpg");
        }
    }
}
