using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public decimal Price { get; set; }

        public CategoryDto CategoryDto { get; set; }

        public int CategoryId { get; set; }

        public string Currency { get; set; }
    }
}
