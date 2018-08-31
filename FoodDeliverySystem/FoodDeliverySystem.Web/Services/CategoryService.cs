using FoodDeliverySystem.Common.Admin.ViewModels;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Services.Interfaces;
using FoodDeliverySystem.Services.Specifications;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Web.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ILogger<CategoryService> _logger;
        private readonly IRepository<CategoryItem> _itemRepository;
        private readonly IAsyncRepository<CategoryType> _typeRepository;
        private readonly IUriComposer _uriComposer;

        public CategoryService(
            ILoggerFactory loggerFactory,
            IRepository<CategoryItem> itemRepository,
            IAsyncRepository<CategoryType> typeRepository,
            IUriComposer uriComposer)
        {
            _logger = loggerFactory.CreateLogger<CategoryService>();
            _itemRepository = itemRepository;
            _typeRepository = typeRepository;
            _uriComposer = uriComposer;
        }

        public async Task<CategoryIndexViewModel> GetCaregoryItems(int pageIndex, int itemsPage, int? typeId)
        {
            _logger.LogInformation("GetCatalogItems called.");

            var filterSpecification = new CategoryFilterSpecification(typeId);
            var root = _itemRepository.List(filterSpecification);

            var totalItems = root.Count();

            var itemsOnPage = root
                .Skip(itemsPage * pageIndex)
                .Take(itemsPage)
                .ToList();

            itemsOnPage.ForEach(x =>
            {
                x.PictureUri = _uriComposer.ComposePicUri(x.PictureUri);
            });

            var vm = new CategoryIndexViewModel()
            {
                CatalogItems = itemsOnPage.Select(i => new CategoryItemViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    PictureUri = i.PictureUri,
                    Price = i.Price
                }),
                Types = await GetTypes(),
                TypesFilterApplied = typeId ?? 0,
                PaginationInfo = new PaginationInfoViewModel()
                {
                    ActualPage = pageIndex,
                    ItemsPerPage = itemsOnPage.Count,
                    TotalItems = totalItems,
                    TotalPages = int.Parse(Math.Ceiling(((decimal)totalItems / itemsPage)).ToString())
                }
            };

            vm.PaginationInfo.Next = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalPages - 1) ? "is-disabled" : "";
            vm.PaginationInfo.Previous = (vm.PaginationInfo.ActualPage == 0) ? "is-disabled" : "";

            return vm;
        }

        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            _logger.LogInformation("GetTypes called.");
            var types = await _typeRepository.ListAllAsync();
            var items = new List<SelectListItem>
            {
                new SelectListItem() { Value = null, Text = "All", Selected = true }
            };
            foreach (CategoryType type in types)
            {
                items.Add(new SelectListItem() { Value = type.Id.ToString(), Text = type.Type });
            }

            return items;
        }
    }
}
