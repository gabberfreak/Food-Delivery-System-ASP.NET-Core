using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Dtos
{
    public class OrderItemDto
    {
        public decimal Quantity { get; set; }

        public int FoodId { get; set; }

        public int OderId { get; set; }
    }
}
