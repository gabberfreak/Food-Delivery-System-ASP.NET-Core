using FoodDeliverySystem.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.ViewModels.Food
{
    public interface IFoodViewModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Picture { get; set; }
        decimal Price { get; set; }
        CategoryDto CategoryDto { get; set; }
        string Currency { get; set; }
        bool IsFavorite { get; set; }
    }
}
