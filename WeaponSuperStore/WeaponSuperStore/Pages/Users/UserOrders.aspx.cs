using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponSuperStore.Models;
using WeaponSuperStore.Models.Repository;
using System.ComponentModel.DataAnnotations;

namespace WeaponSuperStore.Pages.Users
{
    public partial class UserOrders : System.Web.UI.Page
    {

        private Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int dispatchID;
                if (int.TryParse(Request.Form["dispatch"], out dispatchID))
                {
                    Order myOrder = repository.Orders.Where(o => o.OrderId == dispatchID && User.Identity.Name.Equals(o.Name)).FirstOrDefault();
                    if (myOrder != null)
                    {
                        myOrder.Dispatched = true;
                        repository.SaveOrder(myOrder);
                    }
                }
            }
        }

        //public IEnumerable<Order> GetUserOrders([Control] bool showDispatched)
        public IEnumerable<Order> GetUserOrders()
        {
            //if (showDispatched)
            //{
               // return repository.Orders;
            //}
           // else
            //{
                return repository.Orders.Where(o => !o.Dispatched && User.Identity.Name.Equals(o.Name));
            //}
        }

        public String TotalWeapon(IEnumerable<OrderLine> orderLines)
        {
            String total = "";
            foreach (OrderLine ol in orderLines)
            {
                total = ol.Weapon.Name + " " + total;
            }
            return total;
        }

        public decimal Total(IEnumerable<OrderLine> orderLines)
        {
            decimal total = 0;
            foreach (OrderLine ol in orderLines)
            {
                total += ol.Weapon.Price * ol.Quantity;
            }
            return total;
        }
    }
}