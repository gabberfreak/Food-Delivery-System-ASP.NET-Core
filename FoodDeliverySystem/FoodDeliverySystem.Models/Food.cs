using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Recept { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Picture { get; set; }

        public string Currency { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
