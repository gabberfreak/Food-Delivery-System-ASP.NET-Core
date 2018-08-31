using System.Threading.Tasks;
using System;
using FoodDeliverySystem.Common.Admin.ViewModels;
using System.Collections.Generic;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Common.Admin.ViewModels
{
    public class OrderViewModel
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public Address ShippingAddress { get; set; }

        public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();
    }
}
