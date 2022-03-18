using LeGordon.Core.DomianValidations;

namespace LeGordon.Adm.Entities;

internal static class ProductValidations
{
    public static void ValidatesName(string name)
    {
        Validations.ValidatesString(name, "Please, inform a valid name for the product");
    }

    public static void ValidatesDescription(string description)
    {
        Validations.ValidatesString(description, "Product's description cannot be empity");
    }

    public static void ValidatesValue(decimal value)
    {
        Validations.ValidadesNull(value, "Product's value cannot be empity");
        Validations.ValidatesValueLowerThanZero(value, "Product's value must be bigger than zero");
    }

    public static void ValidatesCategoryValue(int categoryId)
    {
        Validations.ValidatesValueLowerThanZero(categoryId, "Please, inform the category");
        Validations.ValidadesNull(categoryId, "Please, inform the category");
    }

    public static void ValideProductData(string name, string description, decimal value, int categoryId)
    {
        ValidatesName(name);   
        ValidatesDescription(description);
        ValidatesValue(value);
        ValidatesCategoryValue(categoryId);
    }
}
