using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeaponSuperStore.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Weapon> Weapons
        {
            get { return context.Weapons; }
        }

        // Чтение данных из таблицы Orders
        public IEnumerable<Order> Orders
        {
            get
            {
                return context.Orders
                    .Include(o => o.OrderLines.Select(ol => ol.Weapon));
            }
        }

        // Сохранить данные заказа в базе данных
        public void SaveOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                order = context.Orders.Add(order);

                foreach (OrderLine line in order.OrderLines)
                {
                    context.Entry(line.Weapon).State= EntityState.Modified;
                }

            }
            else
            {
                Order dbOrder = context.Orders.Find(order.OrderId);
                if (dbOrder != null)
                {
                    dbOrder.Name = order.Name;
                    dbOrder.Line1 = order.Line1;
                    dbOrder.Line2 = order.Line2;
                    dbOrder.Line3 = order.Line3;
                    dbOrder.City = order.City;
                    dbOrder.GiftWrap = order.GiftWrap;
                    dbOrder.Dispatched = order.Dispatched;
                }
            }
            context.SaveChanges();
        }

        public void SaveWeapon(Weapon weapon)
        {
            if (weapon.WeaponId == 0)
            {
                weapon = context.Weapons.Add(weapon);
            }
            else
            {
                Weapon dbWeapon = context.Weapons.Find(weapon.WeaponId);
                if (dbWeapon != null)
                {
                    dbWeapon.Name = weapon.Name;
                    dbWeapon.Weight = weapon.Weight;
                    dbWeapon.Price = weapon.Price;
                    dbWeapon.Category = weapon.Category;
                }
            }
            context.SaveChanges();
        }

        public void DeleteWeapon(Weapon weapon)
        {
            IEnumerable<Order> orders = context.Orders
                .Include(o => o.OrderLines.Select(ol => ol.Weapon))
                .Where(o => o.OrderLines
                    .Count(ol => ol.Weapon.WeaponId == weapon.WeaponId) > 0)
                .ToArray();

            foreach (Order order in orders)
            {
                context.Orders.Remove(order);
            }
            context.Weapons.Remove(weapon);
            context.SaveChanges();
        }
    }
}