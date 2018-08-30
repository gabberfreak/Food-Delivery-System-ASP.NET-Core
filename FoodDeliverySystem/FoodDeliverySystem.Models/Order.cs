using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class Order : Base
    {
        private Order()
        {
        }

        public Order(string buyerId, Address shipToAddress, List<OrderItem> items)
        {
            Guard.Against.NullOrEmpty(buyerId, nameof(buyerId));
            Guard.Against.Null(shipToAddress, nameof(shipToAddress));
            Guard.Against.Null(items, nameof(items));

            items = new List<OrderItem>();
            BuyerId = buyerId;
            ShipToAddress = shipToAddress;

            this.OrderDate = DateTime.Now;
        }

        //public int Id { get; set; }

        public string BuyerId { get; set; }

        public Address ShipToAddress { get; private set; }

        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public decimal Total()
        {
            var total = 0m;
            foreach (var item in OrderItems)
            {
                total += item.Price * item.Price;
            }
            return total;
        }
    }
}
