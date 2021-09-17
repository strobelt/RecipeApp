using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeDatabase;

namespace RecipeApi
{
    public static class RecipeContextServiceCollectionExtensions
    {
        public static void AddRecipeDbContext(this IServiceCollection serviceCollection,
            string connectionString)
            => serviceCollection.AddDbContext<RecipeContext>(
                options => options.UseSqlServer(connectionString));
    }
}
