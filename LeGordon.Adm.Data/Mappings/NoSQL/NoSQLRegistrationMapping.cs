using LeGordon.Adm.Domain.ValueObjects;
using LeGordon.Adm.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace LeGordon.Adm.Data.Mappings.NoSQL
{
    public static class NoSQLRegistrationMapping
    {
        public static void RegisterNoSqlMapping()
        {
            BsonClassMap.RegisterClassMap<Product>(p =>
            {
                p.MapIdField(x => x.Id);
                p.MapField(x => x.Name);
                p.MapField(x => x.Description);
                p.MapField(x => x.Price);
                p.UnmapField(x => x.CategoryId);

            });

            BsonClassMap.RegisterClassMap<Category>(c =>
            {
                c.AutoMap();
                c.MapIdField(x => x.Id);
            });

            BsonClassMap.RegisterClassMap<ProductImage>(pi => { 
                pi.AutoMap();
                pi.MapIdField(pi => pi.Id);
            });

        }

    }
}
