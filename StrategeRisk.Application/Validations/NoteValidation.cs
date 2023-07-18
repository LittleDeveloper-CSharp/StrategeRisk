using StrategeRisk.Domain.Models;

namespace StrategeRisk.Application.Validations
{
    internal static class NoteValidation
    {
        public static bool Validation(this Note note)
        {
            if(string.IsNullOrEmpty(note.InvoiceNumber))
                return false;

            return true;
        }
    }
}
