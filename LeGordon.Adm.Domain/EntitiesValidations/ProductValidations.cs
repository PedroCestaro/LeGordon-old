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

    public static void ValidatesPrice(decimal price)
    {
        Validations.ValidadesNull(price, "Product's price cannot be empity");
        Validations.ValidatesValueLowerThanZero(price, "Product's price must be bigger than zero");
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
        ValidatesPrice(value);
        ValidatesCategoryValue(categoryId);
    }
}
