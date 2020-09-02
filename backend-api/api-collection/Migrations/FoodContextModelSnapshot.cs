﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_collection;

namespace api_collection.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api_collection.Models.FoodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodCategory = "Vegetarian",
                            FoodImage = "vegetables.jpg"
                        },
                        new
                        {
                            Id = 2,
                            FoodCategory = "Chicken",
                            FoodImage = "chicken.jpg"
                        },
                        new
                        {
                            Id = 3,
                            FoodCategory = "Beef",
                            FoodImage = "skirtsteak.jpg"
                        },
                        new
                        {
                            Id = 4,
                            FoodCategory = "Pork",
                            FoodImage = "pork.jpg"
                        });
                });

            modelBuilder.Entity("api_collection.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CookTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 2,
                            CookTime = "20 minutes",
                            FoodTypeId = 1,
                            Ingredients = "Cottage Cheese Cubes, Curry Sauce, Peas",
                            RecipeImage = "matarPaneer.jpg",
                            RecipeName = "Matar Paneer"
                        },
                        new
                        {
                            RecipeId = 3,
                            CookTime = "18 minutes",
                            FoodTypeId = 1,
                            Ingredients = "Black Beans, Quinoa, Corn, Brown Rice, Lettuce, Tomato, Guac, Brioche Bun",
                            RecipeImage = "blackBeanBurger.jpg",
                            RecipeName = "Black Bean Burger"
                        },
                        new
                        {
                            RecipeId = 4,
                            CookTime = "15 minutes",
                            FoodTypeId = 1,
                            Ingredients = "Zucchini, Marinara Sauce, Squash, Onion",
                            RecipeImage = "ratatouille.jpg",
                            RecipeName = "Ratatouille"
                        },
                        new
                        {
                            RecipeId = 5,
                            CookTime = "75 minutes",
                            FoodTypeId = 2,
                            Ingredients = "Chicken, Cheese, Beans, Tortillas, Enchilada Sauce, Rice, Chili",
                            RecipeImage = "chickenEnchiladas.jpg",
                            RecipeName = "Chicken Enchiladas"
                        },
                        new
                        {
                            RecipeId = 6,
                            CookTime = "60 minutes",
                            FoodTypeId = 2,
                            Ingredients = "Chicken, Mozzarella Cheese, Shredded Parmesean Cheese, Red Sauce, Pasta, Panko, Butter",
                            RecipeImage = "chickenParmesan.jpg",
                            RecipeName = "Chicken Parmesean"
                        },
                        new
                        {
                            RecipeId = 7,
                            CookTime = "35 minutes",
                            FoodTypeId = 2,
                            Ingredients = "Chicken, Grease, Flour, Cayenne Pepper, Salt, Pepper, Butter Milk",
                            RecipeImage = "friedChicken.jpg",
                            RecipeName = "Fried Chicken"
                        },
                        new
                        {
                            RecipeId = 8,
                            CookTime = "17 minutes",
                            FoodTypeId = 3,
                            Ingredients = "Angus Beef, Bacon, Mayo, Ketchup, Lettuce, Tomato, Sesame Seed Bun",
                            RecipeImage = "angusBurger.jpg",
                            RecipeName = "Angus Burger"
                        },
                        new
                        {
                            RecipeId = 9,
                            CookTime = "20 minutes",
                            FoodTypeId = 3,
                            Ingredients = "USDA Prime Beef",
                            RecipeImage = "steak.jpg",
                            RecipeName = "Steak"
                        },
                        new
                        {
                            RecipeId = 10,
                            CookTime = "45 minutes",
                            FoodTypeId = 3,
                            Ingredients = "Beef, Carrots, Celery, Potatos, Bay Leaf, Rosemary, Salt, Pepper, Beef Stock, Flour",
                            RecipeImage = "potRoast.jpg",
                            RecipeName = "Pot Roast"
                        },
                        new
                        {
                            RecipeId = 11,
                            CookTime = "20 minutes",
                            FoodTypeId = 4,
                            Ingredients = "Juicy pork tenderloin.",
                            RecipeImage = "pork.jpg",
                            RecipeName = "Pork Tenderloin"
                        },
                        new
                        {
                            RecipeId = 12,
                            CookTime = "38 minutes",
                            FoodTypeId = 4,
                            Ingredients = "Summertime, winter warmth, simply a light dish",
                            RecipeImage = "kalesoup.jpg",
                            RecipeName = "Chicken, Kale & Chorizo Soup"
                        },
                        new
                        {
                            RecipeId = 13,
                            CookTime = "38 minutes",
                            FoodTypeId = 2,
                            Ingredients = "A hearty soup I know the family will enjoy",
                            RecipeImage = "kalesoup.jpg",
                            RecipeName = "Chicken, Kale & Chorizo Soup"
                        },
                        new
                        {
                            RecipeId = 14,
                            CookTime = "25 minutes",
                            FoodTypeId = 3,
                            Ingredients = "Juicy, tender beef in every bite",
                            RecipeImage = "skirtsteak.jpg",
                            RecipeName = "Skirt Steak Au Jus"
                        });
                });

            modelBuilder.Entity("api_collection.Models.Recipe", b =>
                {
                    b.HasOne("api_collection.Models.FoodType", "FoodType")
                        .WithMany("recipes")
                        .HasForeignKey("FoodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
