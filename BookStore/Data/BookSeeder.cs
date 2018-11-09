
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public static class BookSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "C001", CategoryName = "Tiểu thuyết", CategoryDes = "Tiểu thuyết nổi tiếng" },
                new Category { CategoryId = "C002", CategoryName = "Truyện ngắn", CategoryDes = "Tuyển tập truyện ngắn" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = "P001", ProductName = "Cuốn theo chiều gió", ProductDes = "Kinh điển", Quantity = 5, CategoryId = "C001" },
                new Product { ProductId = "P002", ProductName = "Mắt biếc", ProductDes = "Việt Nam", Quantity = 12 , CategoryId = "C002"}
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer{ CustomerId = "Cust001", CustomerType = CustType.Normal },
                new Customer{ CustomerId = "Cust002", CustomerType = CustType.Gold }
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
                new SaleOrderDetail { SaleOrderDetailId = "SOD001", ProductId = "P001", Quantity = 1, UnitPrice = 150000, SaleOrderId = "SO001"},
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


        //private readonly AppDbContext _context;

        //public BookSeeder(AppDbContext context)
        //{
        //    _context = context;
        //}

        //public void Seed()
        //{
        //    _context.Database.EnsureCreated();

        //    if (_context.Categories.Any())
        //    {
        //        var categories = new List<Category>
        //        {
        //            new Category {
        //                CategoryId = "C001",
        //                CategoryName = "Tiểu thuyết",
        //                CategoryDes = "Tiểu thuyết nổi tiếng" ,
        //                Products =  new List<Product>{ new Product{ ProductId = "P001", ProductName = "Cuốn theo chiều gió", ProductDes = "Kinh điển", Quantity = 5}}
        //            },
        //            new Category {
        //                CategoryId = "C002",
        //                CategoryName = "Truyện ngắn",
        //                CategoryDes = "Tuyển tập truyện ngắn",
        //                Products =  new List<Product>{ new Product{ ProductId = "P002", ProductName = "Mắt biếc", ProductDes = "Việt Nam", Quantity = 12}}
        //            }
        //        };
        //        _context.AddRange(categories);
        //        _context.SaveChanges();
        //    }
        //if (_context.Customers.Any())
        //{
        //    var customers = new List<Customer>
        //    {
        //        new Customer {
        //            CustomerId = "Cust001",
        //            CustomerType = CustType.Normal,
        //            PersonInfo = new PersonInfo{ FirstName = "Meo", LastName = "Meo", Phone = "0354464467", Email = "meomeo@gmail.com"},
        //            SaleOrders = new List<SaleOrder>{
        //                new SaleOrder {
        //                    SaleOrderId = "SO001",
        //                    OrderDate = DateTime.Now,
        //                    TotalPrice = 150000,
        //                    SaleOrderDetails = new List<SaleOrderDetail>{ new SaleOrderDetail { ProductId = "P001", Quantity = 1, UnitPrice = 150000} },
        //                    ReceiveProduct = new ReceiveProduct{ ShipToName = "Ichi", ShipToPhone = "0888888888"},
        //                    Shipper = new Shipper{ ShipperId = "SP001", ContactPhone = "094123321", ContactName = "Anga"}
        //                }
        //            }
        //        },
        //        new Customer {
        //            CustomerId = "Cust002",
        //            CustomerType = CustType.Gold,
        //            PersonInfo = new PersonInfo{ FirstName = "Gau", LastName = "Gau", Phone = "094464467", Email = "gaugau@gmail.com"},
        //            SaleOrders = new List<SaleOrder>{
        //                new SaleOrder {
        //                    SaleOrderId = "SO002",
        //                    OrderDate = DateTime.Now,
        //                    TotalPrice = 500000,
        //                    SaleOrderDetails = new List<SaleOrderDetail>{ new SaleOrderDetail { ProductId = "P002", Quantity = 2, UnitPrice = 250000} },
        //                    ReceiveProduct = new ReceiveProduct{ ShipToName = "Gau Gau", ShipToPhone = "094464467"},
        //                    Shipper = new Shipper{ ShipperId = "SP002", ContactPhone = "037864457", ContactName = "Husky"}
        //                }
        //            }
        //        }
        //    };
        //    _context.AddRange(customers);
        //}            
        //}
    }
}
