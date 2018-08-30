using FoodDeliverySystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Services
{
    public class UriComposer : IUriComposer
    {
        private readonly CategorySettings _categorySettings;

        public UriComposer(CategorySettings catalogSettings) => _categorySettings = catalogSettings;

        public string ComposePicUri(string uriTemplate)
        {
            return uriTemplate.Replace("http://catalogbaseurltobereplaced", _categorySettings.CategoryBaseUrl);
        }
    }
}
