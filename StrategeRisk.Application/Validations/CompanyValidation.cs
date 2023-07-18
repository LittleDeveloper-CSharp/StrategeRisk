using StrategeRisk.Domain.Models;

namespace StrategeRisk.Application.Validations
{
    internal static class CompanyValidation
    {
        public static bool Validation(this Company company)
        {
            if(string.IsNullOrEmpty(company.Name))
                return false;

            if (string.IsNullOrEmpty(company.Name))
                return false;

            if (string.IsNullOrEmpty(company.Address))
                return false;

            if(string.IsNullOrEmpty(company.Phone))
                return false;

            return true;
        }
    }
}
