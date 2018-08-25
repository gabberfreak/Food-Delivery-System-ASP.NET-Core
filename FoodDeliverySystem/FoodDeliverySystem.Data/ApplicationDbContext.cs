using System;
using System.Collections.Generic;
using System.Text;
using FoodDeliverySystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliverySystem.Data
{
    public class FoodDeliveryContext : IdentityDbContext
    {
        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options)
             : base(options)
        {
        }

        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(x => x.UserProfile)
                .WithOne(x => x.User)
                .HasForeignKey<UserProfile>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Food>(b =>
            {
                b.HasMany<OrderItem>().WithOne().HasForeignKey(x => x.FoodId).IsRequired();
            });

            builder.Entity<OrderItem>(b =>
            {
                b.HasKey(oi => new { oi.FoodId, oi.OderId });
                b.ToTable("OrderItems");
            });

            builder.Entity<Order>(b =>
            {
                b.HasOne<User>().WithMany(x => x.Orders).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade).IsRequired();
                b.HasMany(x => x.OrderItems).WithOne().HasForeignKey(x => x.OderId).OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<Category>(b =>
            {
                b.HasMany(x => x.Foods).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
                b.ToTable("Categories");
            });
        }
    }
}
