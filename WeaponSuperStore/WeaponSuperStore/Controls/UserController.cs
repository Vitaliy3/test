using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeaponSuperStore.Models;

namespace WeaponSuperStore.Controls
{
    [Authorize(Roles = "Администратор")]
    public class UserController : Controller
    {
        private HelpWeaponContext db = new HelpWeaponContext();

        [HttpGet]
        public ActionResult Index()
        {
            //var users = db.Users.Include(u => u.Department).Include(u => u.Role).ToList();
            //return View(users);
            return View();
        }
    }
}