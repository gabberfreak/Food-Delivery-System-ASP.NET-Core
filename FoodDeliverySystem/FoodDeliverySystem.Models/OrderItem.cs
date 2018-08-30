using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class OrderItem
    {
        private OrderItem()
        {

        }

        public OrderItem(CategoryItemOrdered itemOrdered, decimal price, int units)
        {
            ItemOrdered = itemOrdered;
            Price = price;
            Units = units;

        }

        public int Id { get; set; }

        public CategoryItemOrdered ItemOrdered { get; set; }

        public decimal Price { get; set; }

        public int Units { get; set; }

    }
}
