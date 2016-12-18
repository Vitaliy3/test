using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeaponSuperStore.Models;
using WeaponSuperStore.Pages.Admin;

namespace WeaponSuperStore.Models
{
    abstract class ShopInventory : Shop
    {
        
        public abstract void GetInventory();
        public abstract void UpdateInventory();
        public abstract void DeleteInventory();
        public abstract void InsertInventory();
    }
}