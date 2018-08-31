using FoodDeliverySystem.Common.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Web.Services
{
    public interface ICategoryService
    {
        Task<CategoryIndexViewModel> GetCaregoryItems(int pageIndex, int itemsPage, int? typeId);
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
