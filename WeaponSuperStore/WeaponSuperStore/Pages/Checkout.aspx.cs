using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeaponSuperStore.Models;
using WeaponSuperStore.Models.Repository;
using WeaponSuperStore.Pages.Helpers;

namespace WeaponSuperStore.Pages
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            checkoutForm.Visible = true;
            checkoutMessage.Visible = false;
            //name.Value = User.Identity.Name;
            if (IsPostBack)
            {
                //ИСПОЛЬЗОВАНИЕ ПАТТЕРНА SingleTon
                Order myOrder = Order.GetInstance();
                if (TryUpdateModel(myOrder,
                   new FormValueProvider(ModelBindingExecutionContext)))
                {

                    myOrder.OrderLines = new List<OrderLine>();

                    Cart myCart = SessionHelper.GetCart(Session);

                    foreach (CartLine line in myCart.Lines)
                    {
                        myOrder.OrderLines.Add(new OrderLine
                        {
                            Order = myOrder,
                            Weapon = line.Weapon,
                            Quantity = line.Quantity
                        });
                    }

                    new Repository().SaveOrder(myOrder);
                    myCart.Clear();

                    checkoutForm.Visible = false;
                    checkoutMessage.Visible = true;
                }
            }
        }
    }
}