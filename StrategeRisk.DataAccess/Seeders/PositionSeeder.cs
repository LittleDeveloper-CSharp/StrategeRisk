using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private static async Task PositionSeed()
        {
            var positions = new EmployeePosition[]
            {
                new EmployeePosition
                {
                    Name = "CEO"
                },
                new EmployeePosition
                {
                    Name = "Dev"
                },
                new EmployeePosition
                {
                    Name = "QA"
                }
            };

            _context.AddRange(positions);

            await _context.SaveChangesAsync();
        }
    }
}
