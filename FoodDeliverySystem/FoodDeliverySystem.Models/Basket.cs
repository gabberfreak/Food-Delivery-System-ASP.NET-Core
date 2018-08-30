using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodDeliverySystem.Models
{
    public class Basket
    {
        public Basket()
        {
            this.Items = new List<BasketItem>();
        }

        public int Id { get; set; }

        public string BuyerId { get; set; }

        public ICollection<BasketItem> Items { get; set; }

        public void AddItem(int categoryItemId, decimal price, int quantity = 1)
        {
            if (!Items.Any(i => i.CategoryItemId == categoryItemId))
            {
                Items.Add(new BasketItem()
                {
                    CategoryItemId = categoryItemId,
                    Quantity = quantity,
                    Price = price
                });
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.CategoryItemId == categoryItemId);
            existingItem.Quantity += quantity;
        }
    }
}
