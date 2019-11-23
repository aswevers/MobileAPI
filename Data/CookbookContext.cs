using MobileProjectAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MobileProjectAPI.Data
{
    public class CookbookContext : DbContext
    {
        public CookbookContext(DbContextOptions<CookbookContext> options) : base(options) { }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
            modelBuilder.Entity<RecipeIngredient>().ToTable("RecipeIngredient");
            modelBuilder.Entity<Category>().ToTable("Category");

        }
    }
}
