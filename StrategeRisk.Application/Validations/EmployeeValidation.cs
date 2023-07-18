using StrategeRisk.Domain.Models;

namespace StrategeRisk.Application.Validations
{
    internal static class EmployeeValidation
    {
        public static bool Validation(this Employee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName))
                return false;

            if (string.IsNullOrEmpty(employee.LastName))
                return false;

            if(DateTime.Now < employee.BirthDate) 
                return false;

            return true;
        }
    }
}
