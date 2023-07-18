using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static ApplicationDbContext _context;

        public static async Task Seed(IServiceScope serviceScope)
        {
            _context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            await CitySeed();
            await StateSeed();
            await CompanySeed();
            await PositionSeed();
            await EmployeeSeed();
            await HistorySeed();
        }
    }
}
