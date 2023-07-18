using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static async Task CitySeed()
        {
            _context.Cities.Add(new City
            {
                Name = "Texas"
            });

            await _context.SaveChangesAsync();
        }
    }
}
