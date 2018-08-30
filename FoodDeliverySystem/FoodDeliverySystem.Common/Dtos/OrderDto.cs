using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Dtos
{
    public class OrderDto
    {

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string UserId { get; set; }

        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}
