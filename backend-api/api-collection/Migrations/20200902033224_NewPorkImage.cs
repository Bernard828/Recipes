using Microsoft.EntityFrameworkCore.Migrations;

namespace api_collection.Migrations
{
    public partial class NewPorkImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                columns: new[] { "Ingredients", "RecipeImage" },
                values: new object[] { "Juicy pork tenderloin.", "pork.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11,
                columns: new[] { "Ingredients", "RecipeImage" },
                values: new object[] { "USDA Prime Beef", "steak.jpg" });
        }
    }
}
