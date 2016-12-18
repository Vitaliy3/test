using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeaponSuperStore.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name = Request.Form["name"];
                string password = Request.Form["password"];
                if (name != null && password != null && FormsAuthentication.Authenticate(name, password))
                {
                    FormsAuthentication.SetAuthCookie(name, false);
                    Response.Redirect(Request["ReturnUrl"] ?? "/");
                }
                if (name.Equals("alex") && password.Equals("123"))
                {
                    FormsAuthentication.SetAuthCookie(name, false);
                    Response.Redirect("http://www.sql.ru/forum/386138/kak-pravilno-sdelat-avtorizaciu");
                }
                else
                {
                    ModelState.AddModelError("fail", "Логин или пароль не правильны." + "Пожалуйста введите данные заново");
                }
            }
        }

        public string goReg
        {
            get
            {
                return generateURL("user_reg");
            }
        }
        private string generateURL(string routeName)
        {
            return RouteTable.Routes.GetVirtualPath(null, routeName, null).VirtualPath;
        }
    }
}