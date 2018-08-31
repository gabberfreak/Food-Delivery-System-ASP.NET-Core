using FoodDeliverySystem.Admin.ViewModels;
using FoodDeliverySystem.Common.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Web.Services
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
