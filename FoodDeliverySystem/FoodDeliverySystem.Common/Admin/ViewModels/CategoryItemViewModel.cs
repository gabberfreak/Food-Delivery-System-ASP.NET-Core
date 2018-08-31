using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.ViewModels
{
    public class CategoryItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUri { get; set; }
        public decimal Price { get; set; }
    }
}
