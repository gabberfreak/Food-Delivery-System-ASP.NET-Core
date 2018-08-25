using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public decimal Quantity { get; set; }

        public int FoodId { get; set; }

        public int OderId { get; set; }
    }
}
