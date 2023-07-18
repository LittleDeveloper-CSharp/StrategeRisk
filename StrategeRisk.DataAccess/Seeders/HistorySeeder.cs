using Microsoft.EntityFrameworkCore;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static async Task HistorySeed()
        {
            var company = await _context.Companies.FirstOrDefaultAsync();
            var city = await _context.Cities.FirstOrDefaultAsync();

            _context.Histories.Add(new Domain.Models.History
            {
                Company = company,
                OrderDate = DateTime.Now,
                StoreCity = city
            });

            await _context.SaveChangesAsync();
        }
    }
}
