using LeGordon.Adm.Entities;
using LeGordon.Adm.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeGordon.Adm.Entities.ValueObjects;

namespace LeGordon.Adm.Data.Contexts
{
    internal class AdmContext : DbContext
    {

        public AdmContext(DbContextOptions <AdmContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Coupon> Coupons { get; set; }  

     }
}
