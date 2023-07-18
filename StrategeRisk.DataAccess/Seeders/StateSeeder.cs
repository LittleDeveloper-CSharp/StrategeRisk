using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static async Task StateSeed()
        {
            _context.States.Add(new State
            {
                Name = "Dallas",
            });

            await _context.SaveChangesAsync();
        }
    }
}
