using Microsoft.EntityFrameworkCore;
using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static async Task CompanySeed()
        {
            var city = await _context.Cities.FirstOrDefaultAsync();
            var state = await _context.States.FirstOrDefaultAsync();

            _context.Add(new Company
            {
                Address = "702 SW 8th Street",
                City = city,
                Name = "Super Mart of the West",
                Phone = "(800) 555-2797",
                State = state
            });

            await _context.SaveChangesAsync();
        }
    }
}
