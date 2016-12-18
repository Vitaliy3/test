using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeaponSuperStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}