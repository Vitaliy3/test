using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeaponSuperStore.Models
{
    public class Order
    {
        private static Order order;
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }

        public static Order GetInstance()
        {
            if (order == null)
            {
                lock (typeof(Order))
                {
                    if (order == null)
                        order = new Order();
                }
            }
            return order;
        }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Weapon Weapon { get; set; }
        public int Quantity { get; set; }
    }
}