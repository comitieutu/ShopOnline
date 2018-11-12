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
                new Category { Id = 1, CategoryName = "Sách", CategoryDes = "Tiểu thuyết nổi tiếng" },
                new Category { Id = 2, CategoryName = "Quần áo", CategoryDes = "Quần áo" }
            );
            
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, UnitPrice = 50, ProductName = "Cuốn theo chiều gió", ProductDes = "Kinh điển", Quantity = 5, CategoryId = 1},
                new Product { Id = 2, UnitPrice = 60, ProductName = "Mắt biếc", ProductDes = "Việt Nam", Quantity = 12, CategoryId = 1 },
                new Product { Id = 3, UnitPrice = 60, ProductName = "Sơ mi", ProductDes = "Việt Nam", Quantity = 11, CategoryId = 2 },
                new Product { Id = 4, UnitPrice = 70, ProductName = "Đầm", ProductDes = "Việt Nam", Quantity = 22, CategoryId = 2 }
            );
            
            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail { Id = 1, ProductImage = "i1.jpg", ProductId = 1},
                new ProductDetail { Id = 2, ProductImage = "i10.jpg", ProductId = 2 },
                new ProductDetail { Id = 3, ProductImage = "i12.jpg", ProductId = 3 },
                new ProductDetail { Id = 4, ProductImage = "i11.jpg", ProductId = 4 }
            );

            modelBuilder.Entity<PersonInfo>().HasData(
                new PersonInfo { Id = 1, UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575", FirstName = "Meo", LastName = "Meo"}
            );
            
            modelBuilder.Entity<Shipper>().HasData(
                new Shipper { Id = 1, ContactPhone = "094123321", ContactName = "Anga" },
                new Shipper { Id = 2, ContactPhone = "037864457", ContactName = "Husky" }
            );
            
            modelBuilder.Entity<SaleOrder>().HasData(
                new SaleOrder { Id = 1, UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575", ShipperId = 1, TotalPrice = 50},
                new SaleOrder { Id = 2, UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575", ShipperId = 1, TotalPrice = 120}
            );
            
            modelBuilder.Entity<SaleOrderDetail>().HasData(
                new SaleOrderDetail { Id = 1, Quantity = 1, UnitPrice = 50, SaleOrderId = 1, ProductId = 1 },
                new SaleOrderDetail { Id = 2, Quantity = 2, UnitPrice = 60, SaleOrderId = 2, ProductId = 3 }
            );
            
            modelBuilder.Entity<ReceiveProduct>().HasData(
                new ReceiveProduct { Id = 1, SaleId = 1, ShipToName = "Ichi", ShipToPhone = "0888888888" },
                new ReceiveProduct { Id = 2, SaleId = 2, ShipToName = "Gau Gau", ShipToPhone = "094464467" }
            );
        }
    }
}
