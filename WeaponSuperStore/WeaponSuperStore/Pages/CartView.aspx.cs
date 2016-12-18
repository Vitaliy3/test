using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponSuperStore.Models;
using WeaponSuperStore.Models.Repository;
using WeaponSuperStore.Pages.Helpers;

namespace WeaponSuperStore.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Repository repository = new Repository();
                int weaponId;
                if (int.TryParse(Request.Form["remove"], out weaponId))
                {
                    Weapon weaponToRemove = repository.Weapons
                        .Where(g => g.WeaponId == weaponId).FirstOrDefault();
                    if (weaponToRemove != null)
                    {
                        SessionHelper.GetCart(Session).RemoveLine(weaponToRemove);
                    }
                }
            }
        }

        public IEnumerable<CartLine> GetCartLines()
        {
            return SessionHelper.GetCart(Session).Lines;
        }

        public decimal CartTotal
        {
            get
            {
                return SessionHelper.GetCart(Session).ComputeTotalValue();
            }
        }

        public string ReturnUrl
        {
            get
            {
                return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL);
            }
        }

        public string CheckoutUrl
        {
            get
            {
                return RouteTable.Routes.GetVirtualPath(null, "checkout", null).VirtualPath;
            }
        }
    }
}