using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDeliverySystem.Data;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Web.Services;

namespace FoodDeliverySystem.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Index(int? brandFilterApplied, int? typesFilterApplied, int? page)
        {
            var itemsPage = 10;
            var catalogModel = await _categoryService.GetCaregoryItems(page ?? 0, itemsPage, typesFilterApplied);
            return View(catalogModel);
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
