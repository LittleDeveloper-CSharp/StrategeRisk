using Microsoft.EntityFrameworkCore;
using StrategeRisk.Domain.Enums;
using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess.Seeders
{
    public static partial class DbSeeder
    {
        private async static Task EmployeeSeed()
        {
            var company = await _context.Companies.FirstOrDefaultAsync();
            var position = await _context.EmployeePositions.FirstOrDefaultAsync();

            _context.Employees.Add(new Employee
            {
                BirthDate= DateTime.Now.AddYears(-20),
                FirstName = "John",
                LastName = "Heart",
                Title = EmployeeTitle.Mr,
                Company = company,
                Position = position
            });

            await _context.SaveChangesAsync();
        }
    }
}
