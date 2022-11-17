using LeGordon.Adm.Entities.EntitiesValidations;

namespace LeGordon.Adm.Entities
{
    public sealed class Category
    {
        public Int32 Id { get; private set; }
        public String Name { get; private set; }    
        public Boolean IsActive { get; private set; }

        public ICollection<Product> Products { get; set; }

        private Category() { }

        public Category(string name)
        {
           Name = name;
           IsActive = true;
           CategoryValidations.ValidatesName(name);
        }

        public void Activate() => IsActive = true;
        public void Deactivate() => IsActive = false;
        public void SetName(string name)
        {
            CategoryValidations.ValidatesName(name);
        }

      
    }
}
