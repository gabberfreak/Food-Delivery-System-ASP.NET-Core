using Ardalis.GuardClauses;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Services
{
    public class OrderService : IOrderService
    {
        private readonly IAsyncRepository<Order> _orderRepository;
        private readonly IAsyncRepository<Basket> _basketRepository;
        private readonly IAsyncRepository<CategoryItem> _itemRepository;

        public OrderService(IAsyncRepository<Basket> basketRepository,
            IAsyncRepository<CategoryItem> itemRepository,
            IAsyncRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
            _basketRepository = basketRepository;
            _itemRepository = itemRepository;
        }

        public async Task CreateOrderAsync(int basketId, Address shippingAddress)
        {
            var basket = await _basketRepository.GetByIdAsync(basketId);
            var items = new List<OrderItem>();
            foreach (var item in basket.Items)
            {
                var categoryItem = await _itemRepository.GetByIdAsync(item.CategoryItemId);
                var itemOrdered = new CategoryItemOrdered(categoryItem.Id, categoryItem.Name, categoryItem.PictureUri);
                var orderItem = new OrderItem(itemOrdered, item.Price, item.Quantity);
                items.Add(orderItem);
            }
            var order = new Order(basket.BuyerId, shippingAddress, items);

            await _orderRepository.AddAsync(order);
        }
    }
}
