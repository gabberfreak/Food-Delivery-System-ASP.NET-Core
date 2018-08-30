using FoodDeliverySystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySystem.Data.Seed
{
    public class SeedData
    {
        public static async Task SeedAsync(FoodDeliveryContext foodContext)
        {
            foodContext.Database.Migrate();

            if (!foodContext.CategoryTypes.Any())
            {
                foodContext.CategoryTypes.AddRange(
                    GetCategoryTypes());

                await foodContext.SaveChangesAsync();
            }

            if (!foodContext.CategoryItems.Any())
            {
                foodContext.CategoryItems.AddRange(
                    GetItems());

                await foodContext.SaveChangesAsync();
            }

            if (!foodContext.Users.Any())
            {
                //AddDefaultUser();
            }
        }

        private static IEnumerable<CategoryType> GetCategoryTypes()
        {
            return new List<CategoryType>()
            {
                new CategoryType() { Type = "Salads"},
                new CategoryType() { Type = "Soups"},
                new CategoryType() { Type = "Meals" },
                new CategoryType() { Type = "Drinks" },
            };
        }

        private static IEnumerable<CategoryItem> GetItems()
        {
            return new List<CategoryItem>()
            {
                new CategoryItem() { CategoryTypeId = 1, Description = "Shopska Salata", Name = "Shopska Salata", Price = 5.6m, PictureUri = "http://gotvach.bg/files/lib/600x350/shopska-salata.jpg" },
                new CategoryItem() { CategoryTypeId = 1, Description = "Grutska Salata", Name = "Grutska Salata", Price = 6.6m, PictureUri = "http://kulinar.bg/pictures/2057_398__5.jpg" },
            };
        }

        //static void AddDefaultUser()
        //{
        //    public static async Task SeedAsync(UserManager<User> userManager)
        //    {
        //        var defaultUser = new ApplicationUser { UserName = "demouser@microsoft.com", Email = "demouser@microsoft.com" };
        //        await userManager.CreateAsync(defaultUser, "Pass@word1");
        //    }
        //}
    }
}
