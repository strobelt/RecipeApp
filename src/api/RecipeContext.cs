using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeApi.Models;

namespace RecipeApi
{
    public class RecipeContext : DbContext
    {
        public DbSet<Ingredient>? Ingredients { get; set; }
        public DbSet<Recipe>? Recipes { get; set; }
        public DbSet<RecipeIngredient>? RecipeIngredients { get; set; }
        public DbSet<Step>? Steps { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<Recipe>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            modelBuilder.Entity<Step>()
                .HasKey(s => s.Id);
        }
    }

    public static class RecipeContextServiceCollectionExtensions
    {
        public static void AddRecipeDbContext(this IServiceCollection serviceCollection,
                string connectionString)
            => serviceCollection.AddDbContext<RecipeContext>(
                options => options.UseSqlServer(connectionString));
    }
}
