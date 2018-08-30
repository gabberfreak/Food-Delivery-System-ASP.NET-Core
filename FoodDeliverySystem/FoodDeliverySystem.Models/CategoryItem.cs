using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class CategoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUri { get; set; }
        public int CategoryTypeId { get; set; }
        public CategoryType CategoryType { get; set; }
        //public int CatalogBrandId { get; set; }
        //public CatalogBrand CatalogBrand { get; set; }
    }
}
