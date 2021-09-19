using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeDatabase
{
    public class DatabaseMigrationService : IHostedService
    {
        private readonly RecipeContext _context;
        private readonly IHostApplicationLifetime _lifetime;

        public DatabaseMigrationService(RecipeContext context, IHostApplicationLifetime lifetime)
        {
            _context = context;
            _lifetime = lifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _context.Database.MigrateAsync(cancellationToken);
            _lifetime.StopApplication();
        }

        public Task StopAsync(CancellationToken cancellationToken) =>
            Task.CompletedTask;
    }
}
