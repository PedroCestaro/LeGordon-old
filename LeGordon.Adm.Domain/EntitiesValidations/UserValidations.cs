using LeGordon.Core.DomianValidations;
using System;

namespace LeGordon.Adm.Entities.EntitiesValidations
{
    internal static class UserValidations
    {
        public static void ValidatesName(string name)
        {
            Validations.ValidatesString(name,"Please inform the user's name.");
        }

        public static void ValidatesEmail(String email)
        {
            Validations.ValidatesString(email, "Please, inform a valid email.");
        }

        public static void ValidatesDocument(string document)
        {
            Validations.ValidatesString(document, "Please, inform a valid document.");
        }

        public static void ValidatesBirthdate(DateTime birthDate)
        {
            Validations.ValidadesNull(birthDate, "Birthdate cannot be empity.");
        }

    }
}
