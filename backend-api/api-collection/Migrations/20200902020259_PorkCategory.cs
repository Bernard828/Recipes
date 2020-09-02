using Microsoft.EntityFrameworkCore.Migrations;

namespace api_collection.Migrations
{
    public partial class PorkCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodImage",
                value: "skirtsteak.jpg");

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "Id", "FoodCategory", "FoodImage" },
                values: new object[] { 4, "Pork", "pork.jpg" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "FoodTypeId", "Ingredients", "RecipeImage", "RecipeName" },
                values: new object[] { 14, "25 minutes", 3, "Juicy, tender beef in every bite", "skirtsteak.jpg", "Skirt Steak Au Jus" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "FoodTypeId", "Ingredients", "RecipeImage", "RecipeName" },
                values: new object[] { 11, "20 minutes", 4, "USDA Prime Beef", "steak.jpg", "Pork Tenderloin" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "FoodTypeId", "Ingredients", "RecipeImage", "RecipeName" },
                values: new object[] { 12, "38 minutes", 4, "Summertime, winter warmth, simply a light dish", "kalesoup.jpg", "Chicken, Kale & Chorizo Soup" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "CookTime", "FoodTypeId", "Ingredients", "RecipeImage", "RecipeName" },
                values: new object[] { 13, "38 minutes", 4, "A hearty soup I know the family will enjoy", "kalesoup.jpg", "Chicken, Kale & Chorizo Soup" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodImage",
                value: "brisket.jpg");
        }
    }
}
