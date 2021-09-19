using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipeApi;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RecipeDatabase
{
    static class Program
    {
        static Task Main(string[] args)
            => CreateHostBuilder(args).RunConsoleAsync();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddRecipeDbContext(
                        hostContext.Configuration.GetConnectionString("RecipeDb"));
                    services.AddHostedService<DatabaseMigrationService>();
                });
    }
}
