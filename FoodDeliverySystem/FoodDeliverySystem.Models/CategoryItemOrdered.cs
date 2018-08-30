using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.GuardClauses;

namespace FoodDeliverySystem.Models
{
    public class CategoryItemOrdered
    {
        private CategoryItemOrdered()
        {
        }

        public int CategoryItemId { get; set; }

        public string ProductName { get; set; }

        public string PictureUri { get; set; }

        public CategoryItemOrdered(int categoryItemId, string productName, string pictureUri)
        {
            Guard.Against.OutOfRange(categoryItemId, nameof(categoryItemId), 1, int.MaxValue);
            Guard.Against.NullOrEmpty(productName, nameof(productName));
            Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));

            CategoryItemId = categoryItemId;
            ProductName = productName;
            PictureUri = pictureUri;

        }
    }
}
