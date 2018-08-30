using FoodDeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Services.Specifications
{
    public class CategoryFilterSpecification : BaseSpecification<CategoryItem>
    {
        public CategoryFilterSpecification(int? typeId)
            : base(i => (!typeId.HasValue || i.CategoryTypeId == typeId))
        {
        }
    }
}
