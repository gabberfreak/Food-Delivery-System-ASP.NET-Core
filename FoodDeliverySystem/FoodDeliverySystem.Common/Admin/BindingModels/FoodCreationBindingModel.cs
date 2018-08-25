using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.BindingModels
{
    public class FoodCreationBindingModel
    {
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(0, 5000000)]
        public decimal Price { get; set; }

        public string Description { get; set; }

    }
}
