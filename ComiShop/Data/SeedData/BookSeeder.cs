using ComiShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.Data.SeedData
{
    public static class BookSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

            var user = new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = false,
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var hasher = new PasswordHasher<ApplicationUser>();
            var hashed = hasher.HashPassword(user, "Pass@word1");
            user.PasswordHash = hashed;

            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "C001", CategoryName = "Tiểu thuyết", CategoryDes = "Tiểu thuyết nổi tiếng" },
                new Category { CategoryId = "C002", CategoryName = "Truyện ngắn", CategoryDes = "Tuyển tập truyện ngắn" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = "P001", ProductName = "Cuốn theo chiều gió", ProductDes = "Kinh điển", Quantity = 5, CategoryId = "C001" },
                new Product { ProductId = "P002", ProductName = "Mắt biếc", ProductDes = "Việt Nam", Quantity = 12, CategoryId = "C002" }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = "Cust001", CustomerType = CustType.Normal },
                new Customer { CustomerId = "Cust002", CustomerType = CustType.Gold }
            );
            modelBuilder.Entity<PersonInfo>().HasData(
                new PersonInfo { FirstName = "Meo", LastName = "Meo", Phone = "0354464467", Email = "meomeo@gmail.com", CustomerId = "Cust001" },
                new PersonInfo { FirstName = "Gau", LastName = "Gau", Phone = "094464467", Email = "gaugau@gmail.com", CustomerId = "Cust002" }
            );
            modelBuilder.Entity<SaleOrder>().HasData(
                new SaleOrder { SaleOrderId = "SO001", OrderDate = DateTime.Now, TotalPrice = 150000, CustomerId = "Cust001" },
                new SaleOrder { SaleOrderId = "SO002", OrderDate = DateTime.Now, TotalPrice = 500000, CustomerId = "Cust002" }
            );
            modelBuilder.Entity<SaleOrderDetail>().HasData(
                new SaleOrderDetail { SaleOrderDetailId = "SOD001", ProductId = "P001", Quantity = 1, UnitPrice = 150000, SaleOrderId = "SO001" },
                new SaleOrderDetail { SaleOrderDetailId = "SOD002", ProductId = "P002", Quantity = 2, UnitPrice = 250000, SaleOrderId = "SO002" }
            );
            modelBuilder.Entity<ReceiveProduct>().HasData(
                new ReceiveProduct { SaleOrderId = "SO001", ShipToName = "Ichi", ShipToPhone = "0888888888" },
                new ReceiveProduct { SaleOrderId = "SO002", ShipToName = "Gau Gau", ShipToPhone = "094464467" }
            );
            modelBuilder.Entity<Shipper>().HasData(
                new Shipper { ShipperId = "SP001", ContactPhone = "094123321", ContactName = "Anga" },
                new Shipper { ShipperId = "SP002", ContactPhone = "037864457", ContactName = "Husky" }
            );
        }
    }
}
