using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponSuperStore.Models;
using WeaponSuperStore.Models.Repository;

namespace WeaponSuperStore.Pages.Admin
{
    public partial class Weapons : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Weapon> GetInventory()
        {
            return repository.Weapons;
        }

        public void UpdateInventory(int WeaponID)
        {
            Weapon myWeapon = repository.Weapons
                .Where(p => p.WeaponId == WeaponID).FirstOrDefault();
            if (myWeapon != null && TryUpdateModel(myWeapon,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.SaveWeapon(myWeapon);
            }
        }

        public void DeleteInventory(int WeaponID)
        {
            Weapon myWeapon = repository.Weapons
                .Where(p => p.WeaponId == WeaponID).FirstOrDefault();
            if (myWeapon != null)
            {
                repository.DeleteWeapon(myWeapon);
            }
        }

        public void InsertInventory()
        {
            Weapon myWeapon = new Weapon();
            if (TryUpdateModel(myWeapon,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.SaveWeapon(myWeapon);
            }
        }
    }
}