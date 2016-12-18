using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponSuperStore.Models
{
    public class Cart
    {
        //statiс для Singleton
        private static List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Weapon weapon, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Weapon.WeaponId == weapon.WeaponId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Weapon = weapon,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Weapon weapon)
        {
            lineCollection.RemoveAll(l => l.Weapon.WeaponId == weapon.WeaponId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Weapon.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Weapon Weapon { get; set; }
        public int Quantity { get; set; }
    }
}