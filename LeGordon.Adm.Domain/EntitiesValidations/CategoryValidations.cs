using LeGordon.Core.DomianValidations;

namespace LeGordon.Adm.Entities.EntitiesValidations
{
    internal static class CategoryValidations
    {
        public static void ValidatesName(String name)
        {
            Validations.ValidatesString(name, "Please inform the name of the category");
        }
    }
}
