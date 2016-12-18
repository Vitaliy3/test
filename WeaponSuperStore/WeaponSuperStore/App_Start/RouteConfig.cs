using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WeaponSuperStore.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");
            routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");
            routes.MapPageRoute("admin_orders", "admin/orders", "~/Pages/Admin/Orders.aspx");
            routes.MapPageRoute("admin_weapons", "admin/weapons", "~/Pages/Admin/Weapons.aspx");

            routes.MapPageRoute("user_orders", "users/orders", "~/Pages/Users/UserOrders.aspx");
            routes.MapPageRoute("user_orders2", "users/orders2", "~/Pages/Admin/UserOrders.aspx");

            routes.MapPageRoute("user_log", "registration", "~/Views/Account/Create.cshtml");
            routes.MapPageRoute("user_reg", "logining", "~/Views/Account/Login.cshtml");


            // Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Add this code to handle non-existing urls
            routes.MapRoute(
                name: "404-PageNotFound",
                // This will handle any non-existing urls
                url: "{*url}",
                // "Shared" is the name of your error controller, and "Error" is the action/page
                // that handles all your custom errors
                defaults: new { controller = "Shared", action = "Error" }
            );
        }
    }
}