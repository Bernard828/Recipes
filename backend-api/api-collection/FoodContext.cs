﻿using api_collection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_collection
{
    public class FoodContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=FoodCollection_Database;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<FoodType>().HasData(
                new FoodType(1, "Vegetarian"),
                new FoodType(2, "Chicken"),
                new FoodType(3, "Beef")
                );
            modelbuilder.Entity<Recipe>().HasData(
                new Recipe(2, "Matar Paneer", "", "Cottage Cheese Cubes, Curry Sauce, Peas", "20 minutes", 1),
                new Recipe(3, "Black Bean Burger", "", "Black Beans, Quinoa, Corn, Brown Rice, Lettuce, Tomato, Guac, Brioche Bun", "18 minutes", 1),
                new Recipe(4, "Ratatouille", "", "Zucchini, Marinara Sauce, Squash, Onion", "15 minutes", 1),
                new Recipe(5, "Chicken Enchiladas", "", "Chicken, Cheese, Beans, Tortillas, Enchilada Sauce, Rice, Chili", "75 minutes", 2),
                new Recipe(6, "Chicken Parmesean", "", "Chicken, Mozzarella Cheese, Shredded Parmesean Cheese, Red Sauce, Pasta, Panko, Butter", "60 minutes", 2),
                new Recipe(7, "Fried Chicken", "", "Chicken, Grease, Flour, Cayenne Pepper, Salt, Pepper, Butter Milk", "35 minutes", 2),
                new Recipe(8, "Angus Burger", "", "Angus Beef, Bacon, Mayo, Ketchup, Lettuce, Tomato, Sesame Seed Bun", "17 minutes", 3),
                new Recipe(9, "Steak", "", "USDA Prime Beef", "20 minutes", 3),
                new Recipe(10, "Pot Roast", "", "Beef, Carrots, Celery, Potatos, Bay Leaf, Rosemary, Salt, Pepper, Beef Stock, Flour", "45 minutes", 3)
                );
        }
    }
}
