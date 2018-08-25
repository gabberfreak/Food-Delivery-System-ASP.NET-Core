using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
