using System;
using System.Collections.Generic;
using System.Text;
using FoodDeliverySystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliverySystem.Data
{
    public class FoodDeliveryContext : IdentityDbContext<User>
    {
        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options)
             : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }

        public virtual DbSet<CategoryItem> CategoryItems { get; set; }

        public virtual DbSet<CategoryType> CategoryTypes { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryItem>().ToTable("Category");

            builder.Entity<CategoryItem>().Property(ci => ci.Id)
                .IsRequired();

            builder.Entity<CategoryItem>().Property(ci => ci.Name)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Entity<CategoryItem>().Property(ci => ci.Price)
                .IsRequired(true);

            builder.Entity<CategoryItem>().Property(ci => ci.PictureUri)
                .IsRequired(false);

            builder.Entity<CategoryItem>().HasOne(ci => ci.CategoryType)
                .WithMany()
                .HasForeignKey(ci => ci.CategoryTypeId);


            builder.Entity<CategoryType>().ToTable("CatalogType");

            builder.Entity<CategoryType>().HasKey(ci => ci.Id);

            builder.Entity<CategoryType>().Property(ci => ci.Id)
               .IsRequired();

            builder.Entity<CategoryType>().Property(cb => cb.Type)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<OrderItem>()
                .OwnsOne(i => i.ItemOrdered);

            builder.Entity<Order>().OwnsOne(o => o.ShipToAddress);
        }
    }
}
