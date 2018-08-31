using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Common.Admin.ViewModels
{
    public class CategoryIndexViewModel
    {
        public IEnumerable<CategoryItemViewModel> CatalogItems { get; set; }
        public IEnumerable<SelectListItem> Brands { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public int? BrandFilterApplied { get; set; }
        public int? TypesFilterApplied { get; set; }
        public PaginationInfoViewModel PaginationInfo { get; set; }
    }
}
