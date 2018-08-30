using FoodDeliverySystem.Common.Admin.ViewModels.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.ViewModels
{
    public interface IOrderViewModel
    {
        IFoodViewModel Food { get; }
        decimal Quantity { get; set; }
        decimal TotalPrice { get; }
        string TotalPriceAnimated { get; set; }
        IOrderViewModel Clone();
    }
}
